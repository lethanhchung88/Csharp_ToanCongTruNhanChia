namespace ToanCongTruNhanChia
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMath = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrimarySchool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddition = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubtraction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMultiplication = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMath});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1323, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMath
            // 
            this.menuMath.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrimarySchool});
            this.menuMath.Name = "menuMath";
            this.menuMath.Size = new System.Drawing.Size(55, 24);
            this.menuMath.Text = "Math";
            this.menuMath.Click += new System.EventHandler(this.mathToolStripMenuItem_Click);
            // 
            // menuPrimarySchool
            // 
            this.menuPrimarySchool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddition,
            this.menuSubtraction,
            this.menuMultiplication,
            this.menuDivision,
            this.menuSettings});
            this.menuPrimarySchool.Name = "menuPrimarySchool";
            this.menuPrimarySchool.Size = new System.Drawing.Size(180, 24);
            this.menuPrimarySchool.Text = "Primary School";
            // 
            // menuAddition
            // 
            this.menuAddition.Name = "menuAddition";
            this.menuAddition.Size = new System.Drawing.Size(237, 24);
            this.menuAddition.Text = "Addition (Plus) +";
            this.menuAddition.Click += new System.EventHandler(this.menuAddition_Click);
            // 
            // menuSubtraction
            // 
            this.menuSubtraction.Name = "menuSubtraction";
            this.menuSubtraction.Size = new System.Drawing.Size(237, 24);
            this.menuSubtraction.Text = "Subtraction (Minus) -";
            this.menuSubtraction.Click += new System.EventHandler(this.menuSubtraction_Click);
            // 
            // menuMultiplication
            // 
            this.menuMultiplication.Name = "menuMultiplication";
            this.menuMultiplication.Size = new System.Drawing.Size(237, 24);
            this.menuMultiplication.Text = "Multiplication (Times) ×";
            this.menuMultiplication.Click += new System.EventHandler(this.menuMultiplication_Click);
            // 
            // menuDivision
            // 
            this.menuDivision.Name = "menuDivision";
            this.menuDivision.Size = new System.Drawing.Size(237, 24);
            this.menuDivision.Text = "Division :";
            this.menuDivision.Click += new System.EventHandler(this.menuDivision_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(237, 24);
            this.menuSettings.Text = "Settings ⚙";
            this.menuSettings.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 543);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Math | Addition + | Subtraction – | Multiplication × | Division :";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMath;
        private System.Windows.Forms.ToolStripMenuItem menuPrimarySchool;
        private System.Windows.Forms.ToolStripMenuItem menuAddition;
        private System.Windows.Forms.ToolStripMenuItem menuSubtraction;
        private System.Windows.Forms.ToolStripMenuItem menuMultiplication;
        private System.Windows.Forms.ToolStripMenuItem menuDivision;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
    }
}

