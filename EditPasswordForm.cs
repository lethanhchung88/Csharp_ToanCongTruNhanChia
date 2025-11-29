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
    public partial class EditPasswordForm : Form
    {
        public string EnteredPassword => txtPassword.Text.Trim();

        public EditPasswordForm()
        {
            InitializeComponent();

            this.Text = "Change operations";

            lblMessage.Text = "Enter password to change operations and mode:";
            btnOK.Text = "OK";
            btnCancel.Text = "Cancel";

            txtPassword.UseSystemPasswordChar = true;

            btnOK.Click += btnOK_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
