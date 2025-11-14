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

        public PracticeForm1()
        {
            InitializeComponent();
            this.KeyPreview = true; // để bắt phím + - * / ở mức form
        }

        private void PracticeForm1_Load(object sender, EventArgs e)
        {
            _currentOperation = InitialOperation;

            GenerateNewQuestion();
            UpdateScoreLabels();
            ResetResultIcon();
            txtAnswer.Focus();
        }

        #region Sinh câu hỏi

        private void GenerateNewQuestion(OperationType? newOp = null)
        {
            if (newOp.HasValue)
                _currentOperation = newOp.Value;

            _currentSolved = false;
            ResetResultIcon();

            // TODO: sau này lấy min/max từ config
            int min = 0;
            int max = 10; // ví dụ 0..10

            switch (_currentOperation)
            {
                case OperationType.Addition:
                    _operand1 = _random.Next(min, max + 1);
                    _operand2 = _random.Next(min, max + 1);
                    _correctResult = _operand1 + _operand2;
                    break;

                case OperationType.Subtraction:
                    _operand1 = _random.Next(min, max + 1);
                    _operand2 = _random.Next(min, max + 1);
                    if (_operand2 > _operand1)
                    {
                        // để kết quả không âm
                        int temp = _operand1;
                        _operand1 = _operand2;
                        _operand2 = temp;
                    }
                    _correctResult = _operand1 - _operand2;
                    break;

                case OperationType.Multiplication:
                    _operand1 = _random.Next(0, 10);  // cho nhỏ lại để dễ
                    _operand2 = _random.Next(0, 10);
                    _correctResult = _operand1 * _operand2;
                    break;

                case OperationType.Division:
                    _operand2 = _random.Next(1, 10); // mẫu khác 0
                    int result = _random.Next(0, 10);
                    _operand1 = _operand2 * result;  // chia hết
                    _correctResult = result;
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
            lblTotalScore.Text = _totalScore.ToString();
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
                ShowWrongIcon();
                txtAnswer.SelectAll();
                return;
            }

            if (userAnswer == _correctResult)
            {
                _currentSolved = true;
                IncreaseScore();
                ShowCorrectIcon();

                // Ví dụ (nếu sau này dùng SoundManager):
                // SoundManager.PlayFromFolder("en", "Correct");
            }
            else
            {
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
            picResult.Visible = true;
            picResult.BackColor = Color.LightGreen;
            // Nếu có icon:
            // picResult.Image = Properties.Resources.iconCorrect;
        }

        private void ShowWrongIcon()
        {
            picResult.Visible = true;
            picResult.BackColor = Color.LightPink;
            // Nếu có icon:
            // picResult.Image = Properties.Resources.iconWrong;
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
            if (e.KeyCode == Keys.Enter)
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
            else if (e.KeyCode == Keys.Multiply)
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
    }
}
