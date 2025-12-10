namespace ToanCongTruNhanChia
{
    partial class PracticeForm1
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
            this.lblExpression = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblScoreAdd = new System.Windows.Forms.Label();
            this.lblScoreSub = new System.Windows.Forms.Label();
            this.lblScoreMul = new System.Windows.Forms.Label();
            this.lblScoreDiv = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.prgSticker = new System.Windows.Forms.ProgressBar();
            this.pnlStickers = new System.Windows.Forms.Panel();
            this.tblStickers = new System.Windows.Forms.TableLayoutPanel();
            this.flpLevel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLevel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLevel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLevel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLevel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLevel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLevel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLevel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLevel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLevel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStickerSound = new System.Windows.Forms.Label();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.chkDiv = new System.Windows.Forms.CheckBox();
            this.chkMul = new System.Windows.Forms.CheckBox();
            this.chkSub = new System.Windows.Forms.CheckBox();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlStickers.SuspendLayout();
            this.tblStickers.SuspendLayout();
            this.grpOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExpression
            // 
            this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpression.Location = new System.Drawing.Point(327, 78);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(269, 55);
            this.lblExpression.TabIndex = 0;
            this.lblExpression.Text = "99 + 99 =";
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(594, 75);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(115, 62);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.Text = "99";
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1432, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 31);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.Enter += new System.EventHandler(this.btnNext_Enter);
            this.btnNext.Leave += new System.EventHandler(this.btnNext_Leave);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1353, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.ForeColor = System.Drawing.Color.Red;
            this.lblTotalScore.Location = new System.Drawing.Point(12, 22);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(81, 39);
            this.lblTotalScore.TabIndex = 6;
            this.lblTotalScore.Text = "999";
            this.lblTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreAdd
            // 
            this.lblScoreAdd.AutoSize = true;
            this.lblScoreAdd.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreAdd.Location = new System.Drawing.Point(99, 23);
            this.lblScoreAdd.Name = "lblScoreAdd";
            this.lblScoreAdd.Size = new System.Drawing.Size(34, 15);
            this.lblScoreAdd.TabIndex = 9;
            this.lblScoreAdd.Text = "999★";
            // 
            // lblScoreSub
            // 
            this.lblScoreSub.AutoSize = true;
            this.lblScoreSub.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreSub.Location = new System.Drawing.Point(99, 46);
            this.lblScoreSub.Name = "lblScoreSub";
            this.lblScoreSub.Size = new System.Drawing.Size(34, 15);
            this.lblScoreSub.TabIndex = 11;
            this.lblScoreSub.Text = "999★";
            // 
            // lblScoreMul
            // 
            this.lblScoreMul.AutoSize = true;
            this.lblScoreMul.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreMul.Location = new System.Drawing.Point(99, 71);
            this.lblScoreMul.Name = "lblScoreMul";
            this.lblScoreMul.Size = new System.Drawing.Size(34, 15);
            this.lblScoreMul.TabIndex = 12;
            this.lblScoreMul.Text = "999★";
            // 
            // lblScoreDiv
            // 
            this.lblScoreDiv.AutoSize = true;
            this.lblScoreDiv.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreDiv.Location = new System.Drawing.Point(99, 92);
            this.lblScoreDiv.Name = "lblScoreDiv";
            this.lblScoreDiv.Size = new System.Drawing.Size(34, 15);
            this.lblScoreDiv.TabIndex = 13;
            this.lblScoreDiv.Text = "999★";
            // 
            // lblAnswer
            // 
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Blue;
            this.lblAnswer.Location = new System.Drawing.Point(383, 18);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(385, 44);
            this.lblAnswer.TabIndex = 14;
            this.lblAnswer.Text = "Keep going!";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Wingdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(715, 80);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 53);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgSticker
            // 
            this.prgSticker.Location = new System.Drawing.Point(8, 245);
            this.prgSticker.Name = "prgSticker";
            this.prgSticker.Size = new System.Drawing.Size(1580, 23);
            this.prgSticker.TabIndex = 16;
            // 
            // pnlStickers
            // 
            this.pnlStickers.AutoScroll = true;
            this.pnlStickers.Controls.Add(this.tblStickers);
            this.pnlStickers.Location = new System.Drawing.Point(8, 272);
            this.pnlStickers.Name = "pnlStickers";
            this.pnlStickers.Size = new System.Drawing.Size(1580, 556);
            this.pnlStickers.TabIndex = 18;
            // 
            // tblStickers
            // 
            this.tblStickers.ColumnCount = 10;
            this.tblStickers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblStickers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblStickers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblStickers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblStickers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblStickers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblStickers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblStickers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblStickers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblStickers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblStickers.Controls.Add(this.flpLevel10, 9, 0);
            this.tblStickers.Controls.Add(this.flpLevel9, 8, 0);
            this.tblStickers.Controls.Add(this.flpLevel8, 7, 0);
            this.tblStickers.Controls.Add(this.flpLevel7, 6, 0);
            this.tblStickers.Controls.Add(this.flpLevel6, 5, 0);
            this.tblStickers.Controls.Add(this.flpLevel5, 4, 0);
            this.tblStickers.Controls.Add(this.flpLevel4, 3, 0);
            this.tblStickers.Controls.Add(this.flpLevel3, 2, 0);
            this.tblStickers.Controls.Add(this.flpLevel2, 1, 0);
            this.tblStickers.Controls.Add(this.flpLevel1, 0, 0);
            this.tblStickers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStickers.Location = new System.Drawing.Point(0, 0);
            this.tblStickers.Name = "tblStickers";
            this.tblStickers.RowCount = 1;
            this.tblStickers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStickers.Size = new System.Drawing.Size(1580, 556);
            this.tblStickers.TabIndex = 0;
            // 
            // flpLevel10
            // 
            this.flpLevel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel10.Location = new System.Drawing.Point(1425, 3);
            this.flpLevel10.Name = "flpLevel10";
            this.flpLevel10.Size = new System.Drawing.Size(152, 550);
            this.flpLevel10.TabIndex = 9;
            // 
            // flpLevel9
            // 
            this.flpLevel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel9.Location = new System.Drawing.Point(1267, 3);
            this.flpLevel9.Name = "flpLevel9";
            this.flpLevel9.Size = new System.Drawing.Size(152, 550);
            this.flpLevel9.TabIndex = 8;
            // 
            // flpLevel8
            // 
            this.flpLevel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel8.Location = new System.Drawing.Point(1109, 3);
            this.flpLevel8.Name = "flpLevel8";
            this.flpLevel8.Size = new System.Drawing.Size(152, 550);
            this.flpLevel8.TabIndex = 7;
            // 
            // flpLevel7
            // 
            this.flpLevel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel7.Location = new System.Drawing.Point(951, 3);
            this.flpLevel7.Name = "flpLevel7";
            this.flpLevel7.Size = new System.Drawing.Size(152, 550);
            this.flpLevel7.TabIndex = 6;
            // 
            // flpLevel6
            // 
            this.flpLevel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel6.Location = new System.Drawing.Point(793, 3);
            this.flpLevel6.Name = "flpLevel6";
            this.flpLevel6.Size = new System.Drawing.Size(152, 550);
            this.flpLevel6.TabIndex = 5;
            // 
            // flpLevel5
            // 
            this.flpLevel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel5.Location = new System.Drawing.Point(635, 3);
            this.flpLevel5.Name = "flpLevel5";
            this.flpLevel5.Size = new System.Drawing.Size(152, 550);
            this.flpLevel5.TabIndex = 4;
            // 
            // flpLevel4
            // 
            this.flpLevel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel4.Location = new System.Drawing.Point(477, 3);
            this.flpLevel4.Name = "flpLevel4";
            this.flpLevel4.Size = new System.Drawing.Size(152, 550);
            this.flpLevel4.TabIndex = 3;
            // 
            // flpLevel3
            // 
            this.flpLevel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel3.Location = new System.Drawing.Point(319, 3);
            this.flpLevel3.Name = "flpLevel3";
            this.flpLevel3.Size = new System.Drawing.Size(152, 550);
            this.flpLevel3.TabIndex = 2;
            // 
            // flpLevel2
            // 
            this.flpLevel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel2.Location = new System.Drawing.Point(161, 3);
            this.flpLevel2.Name = "flpLevel2";
            this.flpLevel2.Size = new System.Drawing.Size(152, 550);
            this.flpLevel2.TabIndex = 1;
            // 
            // flpLevel1
            // 
            this.flpLevel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel1.Location = new System.Drawing.Point(3, 3);
            this.flpLevel1.Name = "flpLevel1";
            this.flpLevel1.Size = new System.Drawing.Size(152, 550);
            this.flpLevel1.TabIndex = 0;
            // 
            // lblStickerSound
            // 
            this.lblStickerSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStickerSound.ForeColor = System.Drawing.Color.Black;
            this.lblStickerSound.Location = new System.Drawing.Point(8, 212);
            this.lblStickerSound.Name = "lblStickerSound";
            this.lblStickerSound.Size = new System.Drawing.Size(793, 54);
            this.lblStickerSound.TabIndex = 19;
            this.lblStickerSound.Text = "Sticker sound";
            this.lblStickerSound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.label1);
            this.grpOperations.Controls.Add(this.lblMode);
            this.grpOperations.Controls.Add(this.cmbMode);
            this.grpOperations.Controls.Add(this.chkDiv);
            this.grpOperations.Controls.Add(this.chkMul);
            this.grpOperations.Controls.Add(this.chkSub);
            this.grpOperations.Controls.Add(this.chkAdd);
            this.grpOperations.Controls.Add(this.lblScoreAdd);
            this.grpOperations.Controls.Add(this.lblScoreSub);
            this.grpOperations.Controls.Add(this.lblScoreMul);
            this.grpOperations.Controls.Add(this.lblTotalScore);
            this.grpOperations.Controls.Add(this.lblScoreDiv);
            this.grpOperations.Location = new System.Drawing.Point(12, 12);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(349, 121);
            this.grpOperations.TabIndex = 20;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Math operations";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "⭐";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(247, 23);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(73, 13);
            this.lblMode.TabIndex = 23;
            this.lblMode.Text = "Change mode";
            // 
            // cmbMode
            // 
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "Manual",
            "Sequential",
            "Random"});
            this.cmbMode.Location = new System.Drawing.Point(250, 42);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(88, 21);
            this.cmbMode.TabIndex = 22;
            this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.cmbMode_SelectedIndexChanged);
            // 
            // chkDiv
            // 
            this.chkDiv.AutoSize = true;
            this.chkDiv.Location = new System.Drawing.Point(139, 92);
            this.chkDiv.Name = "chkDiv";
            this.chkDiv.Size = new System.Drawing.Size(81, 17);
            this.chkDiv.TabIndex = 0;
            this.chkDiv.Text = "Division ( : )";
            this.chkDiv.UseVisualStyleBackColor = true;
            this.chkDiv.CheckedChanged += new System.EventHandler(this.OperationCheckBox_CheckedChanged);
            // 
            // chkMul
            // 
            this.chkMul.AutoSize = true;
            this.chkMul.Location = new System.Drawing.Point(139, 69);
            this.chkMul.Name = "chkMul";
            this.chkMul.Size = new System.Drawing.Size(102, 17);
            this.chkMul.TabIndex = 0;
            this.chkMul.Text = "Multiplication (×)";
            this.chkMul.UseVisualStyleBackColor = true;
            this.chkMul.CheckedChanged += new System.EventHandler(this.OperationCheckBox_CheckedChanged);
            // 
            // chkSub
            // 
            this.chkSub.AutoSize = true;
            this.chkSub.Location = new System.Drawing.Point(139, 46);
            this.chkSub.Name = "chkSub";
            this.chkSub.Size = new System.Drawing.Size(92, 17);
            this.chkSub.TabIndex = 0;
            this.chkSub.Text = "Subtraction (-)";
            this.chkSub.UseVisualStyleBackColor = true;
            this.chkSub.CheckedChanged += new System.EventHandler(this.OperationCheckBox_CheckedChanged);
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Location = new System.Drawing.Point(139, 23);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(79, 17);
            this.chkAdd.TabIndex = 0;
            this.chkAdd.Text = "Addition (+)";
            this.chkAdd.UseVisualStyleBackColor = true;
            this.chkAdd.CheckedChanged += new System.EventHandler(this.OperationCheckBox_CheckedChanged);
            // 
            // btnSkip
            // 
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(1513, 12);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 31);
            this.btnSkip.TabIndex = 21;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1274, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 31);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(366, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 114);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(801, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 254);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // PracticeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 831);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.lblStickerSound);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.pnlStickers);
            this.Controls.Add(this.prgSticker);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Name = "PracticeForm1";
            this.Text = "Practice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PracticeForm1_FormClosing);
            this.Load += new System.EventHandler(this.PracticeForm1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PracticeForm1_KeyDown);
            this.pnlStickers.ResumeLayout(false);
            this.tblStickers.ResumeLayout(false);
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblScoreAdd;
        private System.Windows.Forms.Label lblScoreSub;
        private System.Windows.Forms.Label lblScoreMul;
        private System.Windows.Forms.Label lblScoreDiv;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ProgressBar prgSticker;
        private System.Windows.Forms.Panel pnlStickers;
        private System.Windows.Forms.TableLayoutPanel tblStickers;
        private System.Windows.Forms.FlowLayoutPanel flpLevel1;
        private System.Windows.Forms.FlowLayoutPanel flpLevel10;
        private System.Windows.Forms.FlowLayoutPanel flpLevel9;
        private System.Windows.Forms.FlowLayoutPanel flpLevel8;
        private System.Windows.Forms.FlowLayoutPanel flpLevel7;
        private System.Windows.Forms.FlowLayoutPanel flpLevel6;
        private System.Windows.Forms.FlowLayoutPanel flpLevel5;
        private System.Windows.Forms.FlowLayoutPanel flpLevel4;
        private System.Windows.Forms.FlowLayoutPanel flpLevel3;
        private System.Windows.Forms.FlowLayoutPanel flpLevel2;
        private System.Windows.Forms.Label lblStickerSound;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.CheckBox chkDiv;
        private System.Windows.Forms.CheckBox chkMul;
        private System.Windows.Forms.CheckBox chkSub;
        private System.Windows.Forms.CheckBox chkAdd;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}