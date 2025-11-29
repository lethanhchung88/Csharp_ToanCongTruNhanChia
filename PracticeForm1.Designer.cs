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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeForm1));
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
            this.picPin1 = new System.Windows.Forms.PictureBox();
            this.picPin2 = new System.Windows.Forms.PictureBox();
            this.picPin3 = new System.Windows.Forms.PictureBox();
            this.picPin4 = new System.Windows.Forms.PictureBox();
            this.picPin5 = new System.Windows.Forms.PictureBox();
            this.picPin10 = new System.Windows.Forms.PictureBox();
            this.picPin6 = new System.Windows.Forms.PictureBox();
            this.picPin7 = new System.Windows.Forms.PictureBox();
            this.picPin8 = new System.Windows.Forms.PictureBox();
            this.picPin9 = new System.Windows.Forms.PictureBox();
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
            this.lblMode = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.chkDiv = new System.Windows.Forms.CheckBox();
            this.chkMul = new System.Windows.Forms.CheckBox();
            this.chkSub = new System.Windows.Forms.CheckBox();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.btnSkip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin9)).BeginInit();
            this.pnlStickers.SuspendLayout();
            this.tblStickers.SuspendLayout();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpression.Location = new System.Drawing.Point(529, 53);
            this.lblExpression.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(296, 69);
            this.lblExpression.TabIndex = 0;
            this.lblExpression.Text = "99 + 99 = ";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(824, 49);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(152, 75);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.Text = "99";
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1909, 15);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 38);
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
            this.btnClose.Location = new System.Drawing.Point(1804, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 38);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.ForeColor = System.Drawing.Color.Red;
            this.lblTotalScore.Location = new System.Drawing.Point(3, 57);
            this.lblTotalScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(133, 49);
            this.lblTotalScore.TabIndex = 6;
            this.lblTotalScore.Text = "999⭐";
            // 
            // lblScoreAdd
            // 
            this.lblScoreAdd.AutoSize = true;
            this.lblScoreAdd.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreAdd.Location = new System.Drawing.Point(132, 28);
            this.lblScoreAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreAdd.Name = "lblScoreAdd";
            this.lblScoreAdd.Size = new System.Drawing.Size(45, 19);
            this.lblScoreAdd.TabIndex = 9;
            this.lblScoreAdd.Text = "999★";
            // 
            // lblScoreSub
            // 
            this.lblScoreSub.AutoSize = true;
            this.lblScoreSub.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreSub.Location = new System.Drawing.Point(132, 57);
            this.lblScoreSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreSub.Name = "lblScoreSub";
            this.lblScoreSub.Size = new System.Drawing.Size(45, 19);
            this.lblScoreSub.TabIndex = 11;
            this.lblScoreSub.Text = "999★";
            // 
            // lblScoreMul
            // 
            this.lblScoreMul.AutoSize = true;
            this.lblScoreMul.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreMul.Location = new System.Drawing.Point(132, 87);
            this.lblScoreMul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreMul.Name = "lblScoreMul";
            this.lblScoreMul.Size = new System.Drawing.Size(45, 19);
            this.lblScoreMul.TabIndex = 12;
            this.lblScoreMul.Text = "999★";
            // 
            // lblScoreDiv
            // 
            this.lblScoreDiv.AutoSize = true;
            this.lblScoreDiv.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreDiv.Location = new System.Drawing.Point(132, 113);
            this.lblScoreDiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreDiv.Name = "lblScoreDiv";
            this.lblScoreDiv.Size = new System.Drawing.Size(45, 19);
            this.lblScoreDiv.TabIndex = 13;
            this.lblScoreDiv.Text = "999★";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Blue;
            this.lblAnswer.Location = new System.Drawing.Point(1064, 66);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(232, 46);
            this.lblAnswer.TabIndex = 14;
            this.lblAnswer.Text = "Keep going!";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Wingdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(985, 55);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(67, 67);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgSticker
            // 
            this.prgSticker.Location = new System.Drawing.Point(11, 289);
            this.prgSticker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prgSticker.Name = "prgSticker";
            this.prgSticker.Size = new System.Drawing.Size(2107, 28);
            this.prgSticker.TabIndex = 16;
            this.prgSticker.Value = 20;
            // 
            // picPin1
            // 
            this.picPin1.Image = ((System.Drawing.Image)(resources.GetObject("picPin1.Image")));
            this.picPin1.Location = new System.Drawing.Point(200, 230);
            this.picPin1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPin1.Name = "picPin1";
            this.picPin1.Size = new System.Drawing.Size(43, 59);
            this.picPin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPin1.TabIndex = 17;
            this.picPin1.TabStop = false;
            // 
            // picPin2
            // 
            this.picPin2.Image = ((System.Drawing.Image)(resources.GetObject("picPin2.Image")));
            this.picPin2.Location = new System.Drawing.Point(411, 230);
            this.picPin2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPin2.Name = "picPin2";
            this.picPin2.Size = new System.Drawing.Size(43, 59);
            this.picPin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPin2.TabIndex = 17;
            this.picPin2.TabStop = false;
            // 
            // picPin3
            // 
            this.picPin3.Image = ((System.Drawing.Image)(resources.GetObject("picPin3.Image")));
            this.picPin3.Location = new System.Drawing.Point(621, 230);
            this.picPin3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPin3.Name = "picPin3";
            this.picPin3.Size = new System.Drawing.Size(43, 59);
            this.picPin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPin3.TabIndex = 17;
            this.picPin3.TabStop = false;
            // 
            // picPin4
            // 
            this.picPin4.Image = ((System.Drawing.Image)(resources.GetObject("picPin4.Image")));
            this.picPin4.Location = new System.Drawing.Point(832, 230);
            this.picPin4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPin4.Name = "picPin4";
            this.picPin4.Size = new System.Drawing.Size(43, 59);
            this.picPin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPin4.TabIndex = 17;
            this.picPin4.TabStop = false;
            // 
            // picPin5
            // 
            this.picPin5.Image = ((System.Drawing.Image)(resources.GetObject("picPin5.Image")));
            this.picPin5.Location = new System.Drawing.Point(1043, 230);
            this.picPin5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPin5.Name = "picPin5";
            this.picPin5.Size = new System.Drawing.Size(43, 59);
            this.picPin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPin5.TabIndex = 17;
            this.picPin5.TabStop = false;
            // 
            // picPin10
            // 
            this.picPin10.Image = ((System.Drawing.Image)(resources.GetObject("picPin10.Image")));
            this.picPin10.Location = new System.Drawing.Point(2096, 230);
            this.picPin10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPin10.Name = "picPin10";
            this.picPin10.Size = new System.Drawing.Size(43, 59);
            this.picPin10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPin10.TabIndex = 17;
            this.picPin10.TabStop = false;
            // 
            // picPin6
            // 
            this.picPin6.Image = ((System.Drawing.Image)(resources.GetObject("picPin6.Image")));
            this.picPin6.Location = new System.Drawing.Point(1253, 230);
            this.picPin6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPin6.Name = "picPin6";
            this.picPin6.Size = new System.Drawing.Size(43, 59);
            this.picPin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPin6.TabIndex = 17;
            this.picPin6.TabStop = false;
            // 
            // picPin7
            // 
            this.picPin7.Image = ((System.Drawing.Image)(resources.GetObject("picPin7.Image")));
            this.picPin7.Location = new System.Drawing.Point(1464, 230);
            this.picPin7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPin7.Name = "picPin7";
            this.picPin7.Size = new System.Drawing.Size(43, 59);
            this.picPin7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPin7.TabIndex = 17;
            this.picPin7.TabStop = false;
            // 
            // picPin8
            // 
            this.picPin8.Image = ((System.Drawing.Image)(resources.GetObject("picPin8.Image")));
            this.picPin8.Location = new System.Drawing.Point(1675, 230);
            this.picPin8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPin8.Name = "picPin8";
            this.picPin8.Size = new System.Drawing.Size(43, 59);
            this.picPin8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPin8.TabIndex = 17;
            this.picPin8.TabStop = false;
            // 
            // picPin9
            // 
            this.picPin9.Image = ((System.Drawing.Image)(resources.GetObject("picPin9.Image")));
            this.picPin9.Location = new System.Drawing.Point(1885, 230);
            this.picPin9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPin9.Name = "picPin9";
            this.picPin9.Size = new System.Drawing.Size(43, 59);
            this.picPin9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPin9.TabIndex = 17;
            this.picPin9.TabStop = false;
            // 
            // pnlStickers
            // 
            this.pnlStickers.AutoScroll = true;
            this.pnlStickers.Controls.Add(this.tblStickers);
            this.pnlStickers.Location = new System.Drawing.Point(11, 335);
            this.pnlStickers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlStickers.Name = "pnlStickers";
            this.pnlStickers.Size = new System.Drawing.Size(2107, 684);
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
            this.tblStickers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblStickers.Name = "tblStickers";
            this.tblStickers.RowCount = 1;
            this.tblStickers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStickers.Size = new System.Drawing.Size(2107, 684);
            this.tblStickers.TabIndex = 0;
            // 
            // flpLevel10
            // 
            this.flpLevel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel10.Location = new System.Drawing.Point(1894, 4);
            this.flpLevel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLevel10.Name = "flpLevel10";
            this.flpLevel10.Size = new System.Drawing.Size(209, 676);
            this.flpLevel10.TabIndex = 9;
            // 
            // flpLevel9
            // 
            this.flpLevel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel9.Location = new System.Drawing.Point(1684, 4);
            this.flpLevel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLevel9.Name = "flpLevel9";
            this.flpLevel9.Size = new System.Drawing.Size(202, 676);
            this.flpLevel9.TabIndex = 8;
            // 
            // flpLevel8
            // 
            this.flpLevel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel8.Location = new System.Drawing.Point(1474, 4);
            this.flpLevel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLevel8.Name = "flpLevel8";
            this.flpLevel8.Size = new System.Drawing.Size(202, 676);
            this.flpLevel8.TabIndex = 7;
            // 
            // flpLevel7
            // 
            this.flpLevel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel7.Location = new System.Drawing.Point(1264, 4);
            this.flpLevel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLevel7.Name = "flpLevel7";
            this.flpLevel7.Size = new System.Drawing.Size(202, 676);
            this.flpLevel7.TabIndex = 6;
            // 
            // flpLevel6
            // 
            this.flpLevel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel6.Location = new System.Drawing.Point(1054, 4);
            this.flpLevel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLevel6.Name = "flpLevel6";
            this.flpLevel6.Size = new System.Drawing.Size(202, 676);
            this.flpLevel6.TabIndex = 5;
            // 
            // flpLevel5
            // 
            this.flpLevel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel5.Location = new System.Drawing.Point(844, 4);
            this.flpLevel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLevel5.Name = "flpLevel5";
            this.flpLevel5.Size = new System.Drawing.Size(202, 676);
            this.flpLevel5.TabIndex = 4;
            // 
            // flpLevel4
            // 
            this.flpLevel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel4.Location = new System.Drawing.Point(634, 4);
            this.flpLevel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLevel4.Name = "flpLevel4";
            this.flpLevel4.Size = new System.Drawing.Size(202, 676);
            this.flpLevel4.TabIndex = 3;
            // 
            // flpLevel3
            // 
            this.flpLevel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel3.Location = new System.Drawing.Point(424, 4);
            this.flpLevel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLevel3.Name = "flpLevel3";
            this.flpLevel3.Size = new System.Drawing.Size(202, 676);
            this.flpLevel3.TabIndex = 2;
            // 
            // flpLevel2
            // 
            this.flpLevel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel2.Location = new System.Drawing.Point(214, 4);
            this.flpLevel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLevel2.Name = "flpLevel2";
            this.flpLevel2.Size = new System.Drawing.Size(202, 676);
            this.flpLevel2.TabIndex = 1;
            // 
            // flpLevel1
            // 
            this.flpLevel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLevel1.Location = new System.Drawing.Point(4, 4);
            this.flpLevel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLevel1.Name = "flpLevel1";
            this.flpLevel1.Size = new System.Drawing.Size(202, 676);
            this.flpLevel1.TabIndex = 0;
            // 
            // lblStickerSound
            // 
            this.lblStickerSound.AutoSize = true;
            this.lblStickerSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStickerSound.Location = new System.Drawing.Point(993, 172);
            this.lblStickerSound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStickerSound.Name = "lblStickerSound";
            this.lblStickerSound.Size = new System.Drawing.Size(223, 39);
            this.lblStickerSound.TabIndex = 19;
            this.lblStickerSound.Text = "Sticker sound";
            // 
            // grpOperations
            // 
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
            this.grpOperations.Location = new System.Drawing.Point(16, 15);
            this.grpOperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOperations.Size = new System.Drawing.Size(465, 149);
            this.grpOperations.TabIndex = 20;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Math operations";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(329, 28);
            this.lblMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(92, 16);
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
            this.cmbMode.Location = new System.Drawing.Point(333, 52);
            this.cmbMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(116, 24);
            this.cmbMode.TabIndex = 22;
            this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.cmbMode_SelectedIndexChanged);
            // 
            // chkDiv
            // 
            this.chkDiv.AutoSize = true;
            this.chkDiv.Location = new System.Drawing.Point(185, 113);
            this.chkDiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDiv.Name = "chkDiv";
            this.chkDiv.Size = new System.Drawing.Size(97, 20);
            this.chkDiv.TabIndex = 0;
            this.chkDiv.Text = "Division ( : )";
            this.chkDiv.UseVisualStyleBackColor = true;
            this.chkDiv.CheckedChanged += new System.EventHandler(this.OperationCheckBox_CheckedChanged);
            // 
            // chkMul
            // 
            this.chkMul.AutoSize = true;
            this.chkMul.Location = new System.Drawing.Point(185, 85);
            this.chkMul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMul.Name = "chkMul";
            this.chkMul.Size = new System.Drawing.Size(124, 20);
            this.chkMul.TabIndex = 0;
            this.chkMul.Text = "Multiplication (×)";
            this.chkMul.UseVisualStyleBackColor = true;
            this.chkMul.CheckedChanged += new System.EventHandler(this.OperationCheckBox_CheckedChanged);
            // 
            // chkSub
            // 
            this.chkSub.AutoSize = true;
            this.chkSub.Location = new System.Drawing.Point(185, 57);
            this.chkSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSub.Name = "chkSub";
            this.chkSub.Size = new System.Drawing.Size(111, 20);
            this.chkSub.TabIndex = 0;
            this.chkSub.Text = "Subtraction (-)";
            this.chkSub.UseVisualStyleBackColor = true;
            this.chkSub.CheckedChanged += new System.EventHandler(this.OperationCheckBox_CheckedChanged);
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Location = new System.Drawing.Point(185, 28);
            this.chkAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(96, 20);
            this.chkAdd.TabIndex = 0;
            this.chkAdd.Text = "Addition (+)";
            this.chkAdd.UseVisualStyleBackColor = true;
            this.chkAdd.CheckedChanged += new System.EventHandler(this.OperationCheckBox_CheckedChanged);
            // 
            // btnSkip
            // 
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(2017, 15);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(100, 38);
            this.btnSkip.TabIndex = 21;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // PracticeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1023);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.lblStickerSound);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.pnlStickers);
            this.Controls.Add(this.picPin9);
            this.Controls.Add(this.picPin8);
            this.Controls.Add(this.picPin7);
            this.Controls.Add(this.picPin6);
            this.Controls.Add(this.picPin10);
            this.Controls.Add(this.picPin5);
            this.Controls.Add(this.picPin4);
            this.Controls.Add(this.picPin3);
            this.Controls.Add(this.picPin2);
            this.Controls.Add(this.picPin1);
            this.Controls.Add(this.prgSticker);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PracticeForm1";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.PracticeForm1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PracticeForm1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPin9)).EndInit();
            this.pnlStickers.ResumeLayout(false);
            this.tblStickers.ResumeLayout(false);
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
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
        private System.Windows.Forms.PictureBox picPin1;
        private System.Windows.Forms.PictureBox picPin2;
        private System.Windows.Forms.PictureBox picPin3;
        private System.Windows.Forms.PictureBox picPin4;
        private System.Windows.Forms.PictureBox picPin5;
        private System.Windows.Forms.PictureBox picPin10;
        private System.Windows.Forms.PictureBox picPin6;
        private System.Windows.Forms.PictureBox picPin7;
        private System.Windows.Forms.PictureBox picPin8;
        private System.Windows.Forms.PictureBox picPin9;
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
    }
}