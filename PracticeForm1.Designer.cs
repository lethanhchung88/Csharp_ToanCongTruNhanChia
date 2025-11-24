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
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblScoreAdd = new System.Windows.Forms.Label();
            this.lblScoreSub = new System.Windows.Forms.Label();
            this.lblScoreMul = new System.Windows.Forms.Label();
            this.lblScoreDiv = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpression.Location = new System.Drawing.Point(31, 364);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(473, 108);
            this.lblExpression.TabIndex = 0;
            this.lblExpression.Text = "99 + 98 = ";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(49, 500);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(279, 116);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.Text = "9999";
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(446, 500);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(124, 116);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 5;
            this.picResult.TabStop = false;
            this.picResult.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1389, 768);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(183, 41);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next >> (Enter)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.Enter += new System.EventHandler(this.btnNext_Enter);
            this.btnNext.Leave += new System.EventHandler(this.btnNext_Leave);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 768);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 41);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.ForeColor = System.Drawing.Color.Red;
            this.lblTotalScore.Location = new System.Drawing.Point(13, 13);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(63, 33);
            this.lblTotalScore.TabIndex = 6;
            this.lblTotalScore.Text = "10$";
            // 
            // lblScoreAdd
            // 
            this.lblScoreAdd.AutoSize = true;
            this.lblScoreAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreAdd.ForeColor = System.Drawing.Color.Red;
            this.lblScoreAdd.Location = new System.Drawing.Point(1442, 569);
            this.lblScoreAdd.Name = "lblScoreAdd";
            this.lblScoreAdd.Size = new System.Drawing.Size(119, 33);
            this.lblScoreAdd.TabIndex = 9;
            this.lblScoreAdd.Text = "10 điểm";
            // 
            // lblScoreSub
            // 
            this.lblScoreSub.AutoSize = true;
            this.lblScoreSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreSub.ForeColor = System.Drawing.Color.Red;
            this.lblScoreSub.Location = new System.Drawing.Point(1442, 615);
            this.lblScoreSub.Name = "lblScoreSub";
            this.lblScoreSub.Size = new System.Drawing.Size(119, 33);
            this.lblScoreSub.TabIndex = 11;
            this.lblScoreSub.Text = "10 điểm";
            // 
            // lblScoreMul
            // 
            this.lblScoreMul.AutoSize = true;
            this.lblScoreMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreMul.ForeColor = System.Drawing.Color.Red;
            this.lblScoreMul.Location = new System.Drawing.Point(1442, 658);
            this.lblScoreMul.Name = "lblScoreMul";
            this.lblScoreMul.Size = new System.Drawing.Size(119, 33);
            this.lblScoreMul.TabIndex = 12;
            this.lblScoreMul.Text = "10 điểm";
            // 
            // lblScoreDiv
            // 
            this.lblScoreDiv.AutoSize = true;
            this.lblScoreDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreDiv.ForeColor = System.Drawing.Color.Red;
            this.lblScoreDiv.Location = new System.Drawing.Point(1442, 705);
            this.lblScoreDiv.Name = "lblScoreDiv";
            this.lblScoreDiv.Size = new System.Drawing.Size(119, 33);
            this.lblScoreDiv.TabIndex = 13;
            this.lblScoreDiv.Text = "10 điểm";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Blue;
            this.lblAnswer.Location = new System.Drawing.Point(43, 638);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(281, 55);
            this.lblAnswer.TabIndex = 14;
            this.lblAnswer.Text = "Keep going!";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Wingdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(334, 505);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(106, 106);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PracticeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 674);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblScoreDiv);
            this.Controls.Add(this.lblScoreMul);
            this.Controls.Add(this.lblScoreSub);
            this.Controls.Add(this.lblScoreAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblExpression);
            this.Name = "PracticeForm1";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.PracticeForm1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PracticeForm1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblScoreAdd;
        private System.Windows.Forms.Label lblScoreSub;
        private System.Windows.Forms.Label lblScoreMul;
        private System.Windows.Forms.Label lblScoreDiv;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblResult;
    }
}