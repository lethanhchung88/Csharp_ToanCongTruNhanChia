using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // debug Debug.WriteLine($"_currentOperation = {_currentOperation}");

namespace ToanCongTruNhanChia
{
    public partial class PracticeForm1 : Form
    {
        public enum OperationType
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        public OperationType InitialOperation { get; set; } = OperationType.Addition;

        private readonly Random _random = new Random();

        // Số lần gần nhất không được trùng phép cộng (tạm thời hằng, sau sẽ cho vào settings)
        private const int MaxAdditionHistory = 121;

        // Đại diện cho 1 phép cộng
        private class AdditionCase
        {
            public int Operand1 { get; set; }
            public int Operand2 { get; set; }
            public string Key { get; set; }   // key giao hoán: "min_max"
        }

        // Tất cả các phép cộng có thể sinh ra theo cấu hình hiện tại (đã gom giao hoán)
        private List<AdditionCase> _allAdditionCases;

        // Tổng số trường hợp cộng có thể có
        private int _additionTotalCases = 0;

        // Lịch sử gần nhất (theo key giao hoán)
        private readonly Queue<string> _additionHistoryQueue = new Queue<string>();
        private readonly HashSet<string> _additionHistorySet = new HashSet<string>();


        private OperationType _currentOperation = OperationType.Addition;
        private int _operand1;
        private int _operand2;
        private int _correctResult;

        private int _totalScore;
        private int _scoreAdd;
        private int _scoreSub;
        private int _scoreMul;
        private int _scoreDiv;

        private bool _currentSolved; // đã trả lời đúng câu hiện tại chưa

        private AppConfig _config;

        public PracticeForm1()
        {
            InitializeComponent();
            this.KeyPreview = true; // để bắt phím + - * / ở mức form
        }

        private void PracticeForm1_Load(object sender, EventArgs e)
        {
            // ẩn các object chưa dùng đến
            lblScoreAdd.Visible = false;
            lblScoreSub.Visible = false;
            lblScoreMul.Visible = false;
            lblScoreDiv.Visible = false;

            _currentOperation = InitialOperation;

            _config = ConfigHelper.LoadConfig();

            if (_config != null && _config.Operations != null)
            {
                _totalScore = _config.TotalScore;

                if (_config.Operations.TryGetValue("add", out var cfgAdd))
                    _scoreAdd = cfgAdd.Score;
                if (_config.Operations.TryGetValue("sub", out var cfgSub))
                    _scoreSub = cfgSub.Score;
                if (_config.Operations.TryGetValue("mul", out var cfgMul))
                    _scoreMul = cfgMul.Score;
                if (_config.Operations.TryGetValue("div", out var cfgDiv))
                    _scoreDiv = cfgDiv.Score;
            }

            // Chuẩn bị danh sách tất cả phép cộng có thể sinh theo cấu hình hiện tại
            var addCfg = GetOperationConfig(OperationType.Addition);
            _allAdditionCases = BuildAllAdditionCases(addCfg);
            _additionTotalCases = _allAdditionCases?.Count ?? 0;

            _additionHistoryQueue.Clear();
            _additionHistorySet.Clear();


            lblAnswer.Text = string.Empty;
            lblResult.Text = string.Empty;

            GenerateNewQuestion();
            UpdateScoreLabels();
            ResetResultIcon();
            txtAnswer.Focus();
        }

        #region Sinh câu hỏi

        private void GenerateNewQuestion(OperationType? newOp = null)
        {
            lblResult.Visible = false;
            lblAnswer.Visible = false;

            if (newOp.HasValue)
                _currentOperation = newOp.Value;

            _currentSolved = false;
            ResetResultIcon();

            // Lấy cấu hình của phép toán hiện tại
            OperationConfig cfg = GetCurrentOperationConfig();

            switch (_currentOperation)
            {
                case OperationType.Addition:
                    //GenerateAdditionQuestion(cfg);
                    GenerateAdditionQuestion_NoDuplicate(cfg);
                    break;

                case OperationType.Subtraction:
                    GenerateSubtractionQuestion(cfg);
                    break;

                case OperationType.Multiplication:
                    GenerateMultiplicationQuestion(cfg);
                    break;

                case OperationType.Division:
                    GenerateDivisionQuestion(cfg);
                    break;
            }

            UpdateExpressionLabel();

            txtAnswer.Text = "";
            txtAnswer.Focus();
        }

        private void UpdateExpressionLabel()
        {
            string opSymbol = GetOperatorSymbol(_currentOperation);
            lblExpression.Text = $"{_operand1} {opSymbol} {_operand2} =";
        }

        private string GetOperatorSymbol(OperationType op)
        {
            switch (op)
            {
                case OperationType.Addition: return "+";
                case OperationType.Subtraction: return "-";
                case OperationType.Multiplication: return "×";
                case OperationType.Division: return "÷";
                default: return "?";
            }
        }

        #endregion

        #region Điểm

        private void UpdateScoreLabels()
        {
            lblTotalScore.Text = _totalScore.ToString() + "$";
            lblScoreAdd.Text = _scoreAdd.ToString();
            lblScoreSub.Text = _scoreSub.ToString();
            lblScoreMul.Text = _scoreMul.ToString();
            lblScoreDiv.Text = _scoreDiv.ToString();
        }

        private void IncreaseScore()
        {
            _totalScore++;

            switch (_currentOperation)
            {
                case OperationType.Addition: _scoreAdd++; break;
                case OperationType.Subtraction: _scoreSub++; break;
                case OperationType.Multiplication: _scoreMul++; break;
                case OperationType.Division: _scoreDiv++; break;
            }

            UpdateScoreLabels();
        }

        private void DecreaseScoreIfPossible()
        {
            if (_totalScore > 0)
                _totalScore--;

            switch (_currentOperation)
            {
                case OperationType.Addition:
                    if (_scoreAdd > 0) _scoreAdd--;
                    break;
                case OperationType.Subtraction:
                    if (_scoreSub > 0) _scoreSub--;
                    break;
                case OperationType.Multiplication:
                    if (_scoreMul > 0) _scoreMul--;
                    break;
                case OperationType.Division:
                    if (_scoreDiv > 0) _scoreDiv--;
                    break;
            }

            UpdateScoreLabels();
        }

        #endregion

        #region Kiểm tra kết quả

        private void CheckAnswer()
        {
            if (_currentSolved)
                return; // đã đúng rồi, không chấm lại

            if (!int.TryParse(txtAnswer.Text.Trim(), out int userAnswer))
            {
                // không phải số → coi như sai, cho bé nhập lại
                //ShowWrongIcon();
                txtAnswer.SelectAll();
                return;
            }

            if (userAnswer == _correctResult)
            {
                // Gọi âm thanh khen + lấy text
                string praiseText;
                bool played = SoundManager.PlayPraise(out praiseText);

                // Nếu phát được âm thanh thì hiển thị text, ngược lại có thể xóa/rỗng
                if (played)
                {
                    lblAnswer.Visible = true;
                    lblAnswer.Text = praiseText + "!";
                }
                else
                {
                    lblAnswer.Text = string.Empty;
                }

                _currentSolved = true;
                IncreaseScore();
                ShowCorrectIcon();

                btnNext.Focus();
                BlinkNextButtonAsync();
            }
            else
            {
                // Gọi âm thanh "try again" + lấy text
                string tryAgainText;
                bool played = SoundManager.PlayTryAgain(out tryAgainText);

                if (played)
                {
                    lblAnswer.Visible = true;
                    lblAnswer.Text = tryAgainText + "!";
                }
                else
                {
                    lblAnswer.Text = string.Empty;
                }
                // Nếu phát được âm thanh thì hiển thị text, ngược lại có thể xóa/rỗng

                DecreaseScoreIfPossible();
                ShowWrongIcon();
                txtAnswer.SelectAll(); // tô đen toàn bộ để bé nhập lại

            }
        }

        #endregion

        #region Icon đúng / sai

        private void ResetResultIcon()
        {
            picResult.Visible = false;
            picResult.BackColor = SystemColors.Control;
        }

        private void ShowCorrectIcon()
        {
            lblResult.Text = ""; // dấu check trong Wingdings
            lblResult.ForeColor = Color.LimeGreen;
            lblResult.Visible = true;
        }

        private void ShowWrongIcon()
        {
            lblResult.Text = ""; // dấu X trong Wingdings
            lblResult.ForeColor = Color.Red;
            lblResult.Visible = true;
        }

        #endregion

        #region Sự kiện điều khiển

        // chỉ cho nhập số và phím điều khiển (Backspace, Delete…)
        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Enter để chấm / qua câu tiếp theo
        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                if (!_currentSolved)
                {
                    CheckAnswer();
                }
                else
                {
                    // đã đúng rồi → Enter qua câu mới cùng phép toán
                    GenerateNewQuestion();
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Phím + - * / để đổi phép toán & qua câu mới (chỉ khi đã trả lời đúng)
        private void PracticeForm1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_currentSolved)
                return; // phải làm đúng câu hiện tại trước

            OperationType? newOp = null;

            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
                newOp = OperationType.Addition;
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
                newOp = OperationType.Subtraction;
            else if (e.KeyCode == Keys.Multiply || (e.KeyCode == Keys.D8 && e.Shift))
                newOp = OperationType.Multiplication;
            else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion) // / trên 1 số layout
                newOp = OperationType.Division;

            if (newOp.HasValue)
            {
                GenerateNewQuestion(newOp.Value);
                e.Handled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!_currentSolved)
            {
                CheckAnswer();
            }
            else
            {
                GenerateNewQuestion();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void btnNext_GotFocus(object sender, EventArgs e)
        {
            // Khi nút Next được focus → đổi màu sáng lên
            btnNext.BackColor = Color.LightYellow;
        }

        private void btnNext_LostFocus(object sender, EventArgs e)
        {
            // Khi mất focus → trả về màu mặc định của nút
            btnNext.BackColor = SystemColors.Control;
        }

        private void btnNext_Enter(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.LightYellow;   // nổi bật khi được focus
        }

        private void btnNext_Leave(object sender, EventArgs e)
        {
            btnNext.BackColor = SystemColors.Control; // trở về màu thường
        }

        private async void BlinkNextButtonAsync()
        {
            // Đảm bảo nút Next có focus
            btnNext.Focus();

            // Màu bình thường và màu highlight
            Color normalColor = SystemColors.Control;
            Color highlightColor = Color.LightYellow;

            // Tạm tắt xử lý LostFocus/GotFocus, nhưng ở đây focus vẫn nằm trên btnNext
            // nên ta có thể đổi màu trực tiếp

            for (int i = 0; i < 3; i++)   // nhấp nháy 3 lần
            {
                btnNext.BackColor = highlightColor;
                await Task.Delay(120);    // 120ms sáng

                btnNext.BackColor = normalColor;
                await Task.Delay(120);    // 120ms tối lại
            }

            // Sau khi nháy xong, để lại màu sáng (như khi đang focus)
            btnNext.BackColor = highlightColor;
        }

        private string GetOperationKey(OperationType op)
        {
            switch (op)
            {
                case OperationType.Addition: return "add";
                case OperationType.Subtraction: return "sub";
                case OperationType.Multiplication: return "mul";
                case OperationType.Division: return "div";
                default: return "add";
            }
        }

        private string GetAdditionKey(int a, int b)
        {
            // cộng có tính giao hoán nên (a,b) và (b,a) cùng 1 key
            if (a <= b) return a.ToString() + "_" + b.ToString();
            return b.ToString() + "_" + a.ToString();
        }

        private OperationConfig GetCurrentOperationConfig()
        {
            if (_config == null || _config.Operations == null)
                return null;

            string key = GetOperationKey(_currentOperation);
            _config.Operations.TryGetValue(key, out var cfg);
            return cfg;
        }

        private OperationConfig GetOperationConfig(OperationType op)
        {
            if (_config == null || _config.Operations == null)
                return null;

            string key = GetOperationKey(op);
            _config.Operations.TryGetValue(key, out var cfg);
            return cfg;
        }


        private int NextInRange(RangeConfig range, int defaultMin, int defaultMax)
        {
            int min = defaultMin;
            int max = defaultMax;

            if (range != null && range.Enabled)
            {
                min = range.Min;
                max = range.Max;
            }

            if (min > max)
            {
                // Nếu cấu hình sai, đảo lại cho chắc
                int tmp = min;
                min = max;
                max = tmp;
            }

            return _random.Next(min, max + 1);
        }

        private void GenerateAdditionQuestionRandomOnly(OperationConfig cfg)
        {
            // == PHẦN CODE CŨ CỦA PHÉP CỘNG ==
            // fallback nếu không có config
            if (cfg == null)
            {
                _operand1 = _random.Next(0, 11);
                _operand2 = _random.Next(0, 11);
                _correctResult = _operand1 + _operand2;
                return;
            }

            // 1) Nếu ResultRange.Enabled = true → ưu tiên theo RULE mới
            if (cfg.ResultRange != null && cfg.ResultRange.Enabled)
            {
                // 1) random Result theo cấu hình
                _correctResult = NextInRange(cfg.ResultRange, 0, 20);

                // 2) random Operand1 theo cấu hình nhưng luôn ≤ Result
                int op1Min = cfg.Operand1Range != null && cfg.Operand1Range.Enabled
                    ? cfg.Operand1Range.Min
                    : 0;

                int op1Max = cfg.Operand1Range != null && cfg.Operand1Range.Enabled
                    ? cfg.Operand1Range.Max
                    : _correctResult;

                if (op1Max > _correctResult) op1Max = _correctResult;
                if (op1Min > op1Max) op1Min = 0;

                _operand1 = _random.Next(op1Min, op1Max + 1);

                // 3) Operand2 = Result - Operand1
                _operand2 = _correctResult - _operand1;
            }
            else
            {
                // 2) Nếu ResultRange bị vô hiệu → random Operand1 & Operand2 theo cấu hình
                _operand1 = NextInRange(cfg.Operand1Range, 0, 10);
                _operand2 = NextInRange(cfg.Operand2Range, 0, 10);
                _correctResult = _operand1 + _operand2;
            }
        }


        private void GenerateAdditionQuestion(OperationConfig cfg)
        {
            // fallback nếu không có config
            if (cfg == null)
            {
                _operand1 = _random.Next(0, 11);
                _operand2 = _random.Next(0, 11);
                _correctResult = _operand1 + _operand2;
                return;
            }

            // 1) Nếu ResultRange.Enabled = true → ưu tiên theo RULE mới
            if (cfg.ResultRange != null && cfg.ResultRange.Enabled)
            {
                // 1) random Result theo cấu hình
                _correctResult = NextInRange(cfg.ResultRange, 0, 20);

                // 2) random Operand1 theo cấu hình nhưng luôn ≤ Result
                int op1Min = cfg.Operand1Range != null && cfg.Operand1Range.Enabled
                    ? cfg.Operand1Range.Min
                    : 0;

                int op1Max = cfg.Operand1Range != null && cfg.Operand1Range.Enabled
                    ? cfg.Operand1Range.Max
                    : _correctResult;

                // đảm bảo không vượt quá Result
                if (op1Max > _correctResult) op1Max = _correctResult;
                if (op1Min > op1Max) op1Min = 0;

                _operand1 = _random.Next(op1Min, op1Max + 1);

                // 3) Operand2 = Result - Operand1  (bỏ qua cấu hình Operand2)
                _operand2 = _correctResult - _operand1;
            }
            else
            {
                // 2) Nếu ResultRange bị vô hiệu → random Operand1 & Operand2 theo cấu hình
                _operand1 = NextInRange(cfg.Operand1Range, 0, 10);
                _operand2 = NextInRange(cfg.Operand2Range, 0, 10);
                _correctResult = _operand1 + _operand2;
            }
        }

        private void GenerateSubtractionQuestion(OperationConfig cfg)
        {
            if (cfg == null)
            {
                _operand1 = _random.Next(0, 11);
                _operand2 = _random.Next(0, 11);
                if (_operand2 > _operand1)
                {
                    int t = _operand1; _operand1 = _operand2; _operand2 = t;
                }
                _correctResult = _operand1 - _operand2;
                return;
            }

            bool nonNegative = cfg.Constraints != null && cfg.Constraints.NonNegativeResult;

            if (cfg.ResultRange != null && cfg.ResultRange.Enabled)
            {
                // random Result trước
                _correctResult = NextInRange(cfg.ResultRange, 0, 10);

                // operand1 >= result
                int op1Min = cfg.Operand1Range != null && cfg.Operand1Range.Enabled
                    ? Math.Max(cfg.Operand1Range.Min, _correctResult)
                    : _correctResult;

                int op1Max = cfg.Operand1Range != null && cfg.Operand1Range.Enabled
                    ? cfg.Operand1Range.Max
                    : _correctResult + 10;

                if (op1Min > op1Max) op1Max = op1Min;

                _operand1 = _random.Next(op1Min, op1Max + 1);
                _operand2 = _operand1 - _correctResult;
            }
            else
            {
                _operand1 = NextInRange(cfg.Operand1Range, 0, 10);
                _operand2 = NextInRange(cfg.Operand2Range, 0, 10);

                if (nonNegative && _operand2 > _operand1)
                {
                    int t = _operand1; _operand1 = _operand2; _operand2 = t;
                }

                _correctResult = _operand1 - _operand2;
            }
        }

        private void GenerateMultiplicationQuestion(OperationConfig cfg)
        {
            if (cfg == null)
            {
                _operand1 = _random.Next(0, 10);
                _operand2 = _random.Next(0, 10);
                _correctResult = _operand1 * _operand2;
                return;
            }

            if (cfg.ResultRange != null && cfg.ResultRange.Enabled)
            {
                // Cách đơn giản: random 2 toán hạng theo range,
                // nếu kết quả ngoài ResultRange thì random lại vài lần.
                int tryCount = 0;
                do
                {
                    _operand1 = NextInRange(cfg.Operand1Range, 0, 10);
                    _operand2 = NextInRange(cfg.Operand2Range, 0, 10);
                    _correctResult = _operand1 * _operand2;
                    tryCount++;
                }
                while (tryCount < 50 &&
                       (_correctResult < cfg.ResultRange.Min || _correctResult > cfg.ResultRange.Max));

                // nếu vẫn không thoả, cứ lấy lần cuối
            }
            else
            {
                _operand1 = NextInRange(cfg.Operand1Range, 0, 10);
                _operand2 = NextInRange(cfg.Operand2Range, 0, 10);
                _correctResult = _operand1 * _operand2;
            }
        }

        private void GenerateDivisionQuestion(OperationConfig cfg)
        {
            if (cfg == null)
            {
                _operand2 = _random.Next(1, 10); // số chia ≠ 0
                int result = _random.Next(0, 10);
                _operand1 = _operand2 * result;
                _correctResult = result;
                return;
            }

            bool divisibleOnly = cfg.Constraints != null && cfg.Constraints.DivisibleOnly;

            // Ở đây em chọn cách: random kết quả trước, rồi random số chia → số bị chia = chia * kết quả
            int resultMin = cfg.ResultRange != null && cfg.ResultRange.Enabled
                ? cfg.ResultRange.Min
                : 0;
            int resultMax = cfg.ResultRange != null && cfg.ResultRange.Enabled
                ? cfg.ResultRange.Max
                : 10;

            if (resultMin < 0) resultMin = 0;          // cho đơn giản
            if (resultMax < resultMin) resultMax = resultMin;

            _correctResult = _random.Next(resultMin, resultMax + 1);

            // số chia (operand2) theo range
            int divisor = NextInRange(cfg.Operand2Range, 1, 9);
            if (divisor == 0) divisor = 1;

            _operand2 = divisor;
            _operand1 = _correctResult * _operand2;    // đảm bảo chia hết

            // Nếu sau này muốn cho phép không chia hết thì có thể sửa chỗ này,
            // còn bây giờ cơ bản là chia hết cho dễ học.
        }

        private List<AdditionCase> BuildAllAdditionCases(OperationConfig cfg)
        {
            var result = new List<AdditionCase>();
            var keySet = new HashSet<string>();

            // Không có config → dùng mặc định giống code cũ: 0..10 cho cả 2 toán hạng
            if (cfg == null)
            {
                for (int a = 0; a <= 10; a++)
                {
                    for (int b = 0; b <= 10; b++)
                    {
                        string key = GetAdditionKey(a, b);
                        if (keySet.Add(key))
                        {
                            result.Add(new AdditionCase
                            {
                                Operand1 = a,
                                Operand2 = b,
                                Key = key
                            });
                        }
                    }
                }
                return result;
            }

            // Trường hợp dùng ResultRange (Enabled = true)
            if (cfg.ResultRange != null && cfg.ResultRange.Enabled)
            {
                int resMin = cfg.ResultRange.Min;
                int resMax = cfg.ResultRange.Max;
                if (resMin > resMax)
                {
                    int tmp = resMin; resMin = resMax; resMax = tmp;
                }

                int op1CfgMin = (cfg.Operand1Range != null && cfg.Operand1Range.Enabled)
                    ? cfg.Operand1Range.Min
                    : 0;
                int op1CfgMax = (cfg.Operand1Range != null && cfg.Operand1Range.Enabled)
                    ? cfg.Operand1Range.Max
                    : 20;    // giống logic mặc định của bạn

                for (int r = resMin; r <= resMax; r++)
                {
                    int op1Min = op1CfgMin;
                    int op1Max = op1CfgMax;

                    if (op1Max > r) op1Max = r; // operand1 không vượt quá result
                    if (op1Min > op1Max) continue;

                    for (int a = op1Min; a <= op1Max; a++)
                    {
                        int b = r - a;
                        if (b < 0) continue;

                        string key = GetAdditionKey(a, b);
                        if (keySet.Add(key))
                        {
                            result.Add(new AdditionCase
                            {
                                Operand1 = a,
                                Operand2 = b,
                                Key = key
                            });
                        }
                    }
                }
            }
            else
            {
                // Không dùng ResultRange → dùng Operand1Range & Operand2Range
                int op1Min = (cfg.Operand1Range != null && cfg.Operand1Range.Enabled)
                    ? cfg.Operand1Range.Min
                    : 0;
                int op1Max = (cfg.Operand1Range != null && cfg.Operand1Range.Enabled)
                    ? cfg.Operand1Range.Max
                    : 10;

                int op2Min = (cfg.Operand2Range != null && cfg.Operand2Range.Enabled)
                    ? cfg.Operand2Range.Min
                    : 0;
                int op2Max = (cfg.Operand2Range != null && cfg.Operand2Range.Enabled)
                    ? cfg.Operand2Range.Max
                    : 10;

                if (op1Min > op1Max)
                {
                    int tmp = op1Min; op1Min = op1Max; op1Max = tmp;
                }
                if (op2Min > op2Max)
                {
                    int tmp = op2Min; op2Min = op2Max; op2Max = tmp;
                }

                for (int a = op1Min; a <= op1Max; a++)
                {
                    for (int b = op2Min; b <= op2Max; b++)
                    {
                        string key = GetAdditionKey(a, b);
                        if (keySet.Add(key))
                        {
                            result.Add(new AdditionCase
                            {
                                Operand1 = a,
                                Operand2 = b,
                                Key = key
                            });
                        }
                    }
                }
            }

            return result;
        }

        private void GenerateAdditionQuestion_NoDuplicate(OperationConfig cfg)
        {
            // Nếu chưa build, build 1 lần (phòng trường hợp load sau)
            if (_allAdditionCases == null)
            {
                _allAdditionCases = BuildAllAdditionCases(cfg);
                _additionTotalCases = _allAdditionCases?.Count ?? 0;
            }

            // Nếu vì lý do nào đó không có case nào → quay về random như cũ
            if (_allAdditionCases == null || _additionTotalCases == 0)
            {
                GenerateAdditionQuestionRandomOnly(cfg);
                return;
            }

            int historyLimit = Math.Min(MaxAdditionHistory, _additionTotalCases);

            // Trường hợp m <= n: nếu đã dùng hết m trường hợp → reset vòng mới
            if (_additionTotalCases <= MaxAdditionHistory &&
                _additionHistorySet.Count >= _additionTotalCases)
            {
                _additionHistorySet.Clear();
                _additionHistoryQueue.Clear();
            }
            else
            {
                // Trường hợp m > n: chỉ giữ lại n phần tử gần nhất
                while (_additionHistoryQueue.Count > historyLimit)
                {
                    string oldKey = _additionHistoryQueue.Dequeue();
                    _additionHistorySet.Remove(oldKey);
                }
            }

            // Lọc các case chưa xuất hiện trong lịch sử gần nhất
            var candidates = _allAdditionCases
                .Where(c => !_additionHistorySet.Contains(c.Key))
                .ToList();

            // Phòng khi vì lý do gì đó không còn candidate → reset lịch sử
            if (candidates.Count == 0)
            {
                _additionHistorySet.Clear();
                _additionHistoryQueue.Clear();
                candidates = _allAdditionCases.ToList();
            }

            // Chọn ngẫu nhiên một phép
            int idx = _random.Next(0, candidates.Count);
            var chosen = candidates[idx];

            _operand1 = chosen.Operand1;
            _operand2 = chosen.Operand2;
            _correctResult = _operand1 + _operand2;

            // Lưu vào lịch sử
            _additionHistoryQueue.Enqueue(chosen.Key);
            _additionHistorySet.Add(chosen.Key);
        }


    }
}
