using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToanCongTruNhanChia
{
    public partial class settingsForm : Form
    {
        private AppConfig _config;

        // cho biết có được phép chỉnh & lưu Settings không
        private bool _canEditSettings = true;
        public settingsForm()
        {
            InitializeComponent();
        }

        private void LoadOperationToUI(
            OperationConfig op,
            CheckBox chkOp1, NumericUpDown numOp1Min, NumericUpDown numOp1Max,
            CheckBox chkOp2, NumericUpDown numOp2Min, NumericUpDown numOp2Max,
            CheckBox chkResult, NumericUpDown numResultMin, NumericUpDown numResultMax)
        {
            // Operand 1
            chkOp1.Checked = op.Operand1Range.Enabled;
            numOp1Min.Value = op.Operand1Range.Min;
            numOp1Max.Value = op.Operand1Range.Max;

            // Operand 2
            chkOp2.Checked = op.Operand2Range.Enabled;
            numOp2Min.Value = op.Operand2Range.Min;
            numOp2Max.Value = op.Operand2Range.Max;

            // Result
            chkResult.Checked = op.ResultRange.Enabled;
            numResultMin.Value = op.ResultRange.Min;
            numResultMax.Value = op.ResultRange.Max;

            // (Tuỳ chọn) disable NumericUpDown nếu không Enable
            ToggleRangeControls(chkOp1, numOp1Min, numOp1Max);
            ToggleRangeControls(chkOp2, numOp2Min, numOp2Max);
            ToggleRangeControls(chkResult, numResultMin, numResultMax);

            // Gắn CheckedChanged để bật/tắt numeric khi tick checkbox
            chkOp1.CheckedChanged += (s, e) => ToggleRangeControls(chkOp1, numOp1Min, numOp1Max);
            chkOp2.CheckedChanged += (s, e) => ToggleRangeControls(chkOp2, numOp2Min, numOp2Max);
            chkResult.CheckedChanged += (s, e) => ToggleRangeControls(chkResult, numResultMin, numResultMax);
        }

        private void ToggleRangeControls(CheckBox chk, params Control[] ctrls)
        {
            foreach (var c in ctrls)
                c.Enabled = chk.Checked;
        }

        private void SaveUIToOperation(
            OperationConfig op,
            CheckBox chkOp1, NumericUpDown numOp1Min, NumericUpDown numOp1Max,
            CheckBox chkOp2, NumericUpDown numOp2Min, NumericUpDown numOp2Max,
            CheckBox chkResult, NumericUpDown numResultMin, NumericUpDown numResultMax)
        {
            // Operand 1
            op.Operand1Range.Enabled = chkOp1.Checked;
            op.Operand1Range.Min = (int)numOp1Min.Value;
            op.Operand1Range.Max = (int)numOp1Max.Value;

            // Operand 2
            op.Operand2Range.Enabled = chkOp2.Checked;
            op.Operand2Range.Min = (int)numOp2Min.Value;
            op.Operand2Range.Max = (int)numOp2Max.Value;

            // Result
            op.ResultRange.Enabled = chkResult.Checked;
            op.ResultRange.Min = (int)numResultMin.Value;
            op.ResultRange.Max = (int)numResultMax.Value;
        }

        /// <summary>
        /// Mật khẩu dùng để mở chế độ "Điều chỉnh" của Settings.
        /// Lưu dạng text thuần trong settings.json.
        /// </summary>
        public string AdminPassword { get; set; } = "Lisa&Helen";

        private void settingsForm_Load(object sender, EventArgs e)
        {
            // 1) Load cấu hình (hoặc mặc định nếu chưa có file)
            _config = ConfigHelper.LoadConfig();

            // 1b) Hỏi mở Chỉ xem hay Điều chỉnh
            _canEditSettings = AskViewOrEditMode();

            // 2) Đổ dữ liệu ra UI cho 4 phép
            LoadOperationToUI(_config.Operations["add"],
                chkAddOpe1Enable, numAddOpe1Min, numAddOpe1Max,
                chkAddOpe2Enable, numAddOpe2Min, numAddOpe2Max,
                chkAddResultEnable, numAddResultMin, numAddResultMax);

            LoadOperationToUI(_config.Operations["sub"],
                chkSubOpe1Enable, numSubOpe1Min, numSubOpe1Max,
                chkSubOpe2Enable, numSubOpe2Min, numSubOpe2Max,
                chkSubResultEnable, numSubResultMin, numSubResultMax);

            LoadOperationToUI(_config.Operations["mul"],
                chkMulOpe1Enable, numMulOpe1Min, numMulOpe1Max,
                chkMulOpe2Enable, numMulOpe2Min, numMulOpe2Max,
                chkMulResultEnable, numMulResultMin, numMulResultMax);

            LoadOperationToUI(_config.Operations["div"],
                chkDivOpe1Enable, numDivOpe1Min, numDivOpe1Max,
                chkDivOpe2Enable, numDivOpe2Min, numDivOpe2Max,
                chkDivResultEnable, numDivResultMin, numDivResultMax);

            // 4) Load cấu hình Sticker
            if (_config.Sticker == null)
                _config.Sticker = new StickerConfig();

            numPointStep.Value = _config.Sticker.PointStep;

            // 5) Áp quyền lên các control (chỉ xem / điều chỉnh)
            ApplyEditPermission(this);

            // 6) Gắn hover sound cho toàn bộ control trên form
            WireHoverSoundRecursive(this);
        }

        private void WireHoverSoundRecursive(Control parent)
        {
            parent.MouseEnter += SettingsControl_MouseEnter;

            foreach (Control child in parent.Controls)
            {
                WireHoverSoundRecursive(child);
            }
        }

        private void SettingsControl_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Control c)
            {
                SoundManager.PlaySettingsHover(c.Name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_canEditSettings)
            {
                MessageBox.Show("Bạn đang ở chế độ 'Chỉ xem', không thể lưu cấu hình.",
                    "Không được phép",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ UI về _config
            SaveUIToOperation(_config.Operations["add"],
                chkAddOpe1Enable, numAddOpe1Min, numAddOpe1Max,
                chkAddOpe2Enable, numAddOpe2Min, numAddOpe2Max,
                chkAddResultEnable, numAddResultMin, numAddResultMax);

            SaveUIToOperation(_config.Operations["sub"],
                chkSubOpe1Enable, numSubOpe1Min, numSubOpe1Max,
                chkSubOpe2Enable, numSubOpe2Min, numSubOpe2Max,
                chkSubResultEnable, numSubResultMin, numSubResultMax);

            SaveUIToOperation(_config.Operations["mul"],
                chkMulOpe1Enable, numMulOpe1Min, numMulOpe1Max,
                chkMulOpe2Enable, numMulOpe2Min, numMulOpe2Max,
                chkMulResultEnable, numMulResultMin, numMulResultMax);

            SaveUIToOperation(_config.Operations["div"],
                chkDivOpe1Enable, numDivOpe1Min, numDivOpe1Max,
                chkDivOpe2Enable, numDivOpe2Min, numDivOpe2Max,
                chkDivResultEnable, numDivResultMin, numDivResultMax);

            // Lưu Sticker config
            if (_config.Sticker == null)
                _config.Sticker = new StickerConfig();

            _config.Sticker.PointStep = (int)numPointStep.Value;

            // Lưu xuống file settings.json
            ConfigHelper.SaveConfig(_config);

            SoundManager.PlayFromFolder("en", "Settings saved");

            MessageBox.Show("Settings saved.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Hỏi người dùng muốn "Chỉ xem" hay "Điều chỉnh".
        /// Nếu chọn Điều chỉnh thì kiểm tra pass, sai thì yêu cầu nhập lại.
        /// Trả về: true  => được chỉnh (edit mode)
        ///         false => chỉ xem (view-only)
        /// </summary>
        private bool AskViewOrEditMode()
        {
            // Đảm bảo luôn có giá trị mặc định cho AdminPassword
            if (string.IsNullOrEmpty(_config.AdminPassword))
            {
                _config.AdminPassword = "Lisa&Helen";
            }

            while (true)
            {
                using (var dlg = new PasswordPromptForm())
                {
                    var result = dlg.ShowDialog(this);
                    if (result != DialogResult.OK)
                    {
                        // Trường hợp rất hiếm, nhưng cứ coi như Chỉ xem
                        return false;
                    }

                    if (dlg.IsViewOnly)
                    {
                        // Người dùng chọn "Chỉ xem"
                        return false;
                    }

                    // Người dùng chọn "Điều chỉnh" -> kiểm tra mật khẩu
                    if (dlg.EnteredPassword == _config.AdminPassword)
                    {
                        // Đúng pass => được chỉnh
                        return true;
                    }

                    // Sai pass => báo lỗi và lặp lại vòng while
                    MessageBox.Show("Mật khẩu không đúng, vui lòng nhập lại.",
                        "Sai mật khẩu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Bật/tắt khả năng chỉnh sửa các control trên form theo _canEditSettings.
        /// Khi chỉ xem: không được đổi NumericUpDown, CheckBox, không bấm Save.
        /// </summary>
        private void ApplyEditPermission(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                // Nút Cancel phải luôn dùng được để thoát
                if (c == btnCancel)
                {
                    c.Enabled = true;
                }
                else if (c is NumericUpDown || c is CheckBox || c is TextBox || c is ComboBox || c is Button)
                {
                    // Nếu là nút Save thì để cuối xử lý bên dưới
                    if (c == btnSave)
                        continue;

                    c.Enabled = _canEditSettings;
                }

                if (c.HasChildren)
                {
                    ApplyEditPermission(c);
                }
            }

            // Cuối cùng, xử lý riêng nút Save
            btnSave.Enabled = _canEditSettings;
        }


    }
}
