namespace Gunchenko_Sudoku
{
    partial class FormStopGame
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
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelStop = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMistakes = new System.Windows.Forms.Label();
            this.labelModeName = new System.Windows.Forms.Label();
            this.labelTimeInt = new System.Windows.Forms.Label();
            this.labelMistakesInt = new System.Windows.Forms.Label();
            this.labelScoreInt = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.buttonContinue.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonContinue.Location = new System.Drawing.Point(198, 415);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(185, 42);
            this.buttonContinue.TabIndex = 0;
            this.buttonContinue.Text = "Продолжить";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelStop.Location = new System.Drawing.Point(245, 61);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(85, 35);
            this.labelStop.TabIndex = 21;
            this.labelStop.Text = "Пауза";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelMode.Location = new System.Drawing.Point(162, 156);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(152, 35);
            this.labelMode.TabIndex = 22;
            this.labelMode.Text = "Складність";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelTime.Location = new System.Drawing.Point(162, 216);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(85, 35);
            this.labelTime.TabIndex = 23;
            this.labelTime.Text = "Пауза";
            // 
            // labelMistakes
            // 
            this.labelMistakes.AutoSize = true;
            this.labelMistakes.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelMistakes.Location = new System.Drawing.Point(162, 276);
            this.labelMistakes.Name = "labelMistakes";
            this.labelMistakes.Size = new System.Drawing.Size(85, 35);
            this.labelMistakes.TabIndex = 24;
            this.labelMistakes.Text = "Пауза";
            // 
            // labelModeName
            // 
            this.labelModeName.AutoSize = true;
            this.labelModeName.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelModeName.Location = new System.Drawing.Point(332, 156);
            this.labelModeName.Name = "labelModeName";
            this.labelModeName.Size = new System.Drawing.Size(85, 35);
            this.labelModeName.TabIndex = 25;
            this.labelModeName.Text = "Пауза";
            // 
            // labelTimeInt
            // 
            this.labelTimeInt.AutoSize = true;
            this.labelTimeInt.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelTimeInt.Location = new System.Drawing.Point(332, 216);
            this.labelTimeInt.Name = "labelTimeInt";
            this.labelTimeInt.Size = new System.Drawing.Size(85, 35);
            this.labelTimeInt.TabIndex = 26;
            this.labelTimeInt.Text = "Пауза";
            // 
            // labelMistakesInt
            // 
            this.labelMistakesInt.AutoSize = true;
            this.labelMistakesInt.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelMistakesInt.Location = new System.Drawing.Point(332, 276);
            this.labelMistakesInt.Name = "labelMistakesInt";
            this.labelMistakesInt.Size = new System.Drawing.Size(85, 35);
            this.labelMistakesInt.TabIndex = 27;
            this.labelMistakesInt.Text = "Пауза";
            // 
            // labelScoreInt
            // 
            this.labelScoreInt.AutoSize = true;
            this.labelScoreInt.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelScoreInt.Location = new System.Drawing.Point(332, 336);
            this.labelScoreInt.Name = "labelScoreInt";
            this.labelScoreInt.Size = new System.Drawing.Size(85, 35);
            this.labelScoreInt.TabIndex = 29;
            this.labelScoreInt.Text = "Пауза";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelScore.Location = new System.Drawing.Point(162, 336);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(85, 35);
            this.labelScore.TabIndex = 28;
            this.labelScore.Text = "Пауза";
            // 
            // FormStopGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 529);
            this.Controls.Add(this.labelScoreInt);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelMistakesInt);
            this.Controls.Add(this.labelTimeInt);
            this.Controls.Add(this.labelModeName);
            this.Controls.Add(this.labelMistakes);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelStop);
            this.Controls.Add(this.buttonContinue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStopGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormStopGame";
            this.Load += new System.EventHandler(this.FormStopGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMistakes;
        private System.Windows.Forms.Label labelModeName;
        private System.Windows.Forms.Label labelTimeInt;
        private System.Windows.Forms.Label labelMistakesInt;
        private System.Windows.Forms.Label labelScoreInt;
        private System.Windows.Forms.Label labelScore;
    }
}