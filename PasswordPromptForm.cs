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
    public partial class PasswordPromptForm : Form
    {
        public string EnteredPassword => txtPassword.Text.Trim();

        /// <summary>
        /// true  => người dùng chọn "Chỉ xem"
        /// false => người dùng chọn "Điều chỉnh"
        /// </summary>
        public bool IsViewOnly { get; private set; } = true;

        public PasswordPromptForm()
        {
            InitializeComponent();
        }

        private void btnViewOnly_Click(object sender, EventArgs e)
        {
            // Người dùng chọn Chỉ xem => không cần mật khẩu
            IsViewOnly = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Người dùng muốn Điều chỉnh => caller sẽ kiểm tra mật khẩu
            IsViewOnly = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PasswordPromptForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu user bấm dấu X hoặc đóng form mà chưa set DialogResult,
            // thì coi như "Chỉ xem"
            if (this.DialogResult == DialogResult.None)
            {
                IsViewOnly = true;
                this.DialogResult = DialogResult.OK;
            }
        }
    }

}
