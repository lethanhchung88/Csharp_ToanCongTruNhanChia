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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            WireMenuSounds();
        }

        private void WireMenuSounds()
        {
            menuMath.MouseEnter += (s, e) => SoundManager.PlayMenu(menuMath.Name);
            menuPrimarySchool.MouseEnter += (s, e) => SoundManager.PlayMenu(menuPrimarySchool.Name);

            menuAddition.MouseEnter += (s, e) => SoundManager.PlayMenu(menuAddition.Name);
            menuSubtraction.MouseEnter += (s, e) => SoundManager.PlayMenu(menuSubtraction.Name);
            menuMultiplication.MouseEnter += (s, e) => SoundManager.PlayMenu(menuMultiplication.Name);
            menuDivision.MouseEnter += (s, e) => SoundManager.PlayMenu(menuDivision.Name);
            menuSettings.MouseEnter += (s, e) => SoundManager.PlayMenu(menuSettings.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mathToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new settingsForm())
            {
                frm.ShowDialog(this);
            }
        }
    }
}
