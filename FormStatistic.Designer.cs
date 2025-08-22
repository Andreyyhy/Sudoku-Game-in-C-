namespace Gunchenko_Sudoku
{
    partial class FormStatistic
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
            this.labelStatistic = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.labelScore3 = new System.Windows.Forms.Label();
            this.labelMistakes3 = new System.Windows.Forms.Label();
            this.labelTime3 = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.labelMistakes2 = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.labelMistakes1 = new System.Windows.Forms.Label();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.labelStatisticDifficult = new System.Windows.Forms.Label();
            this.panelDifficult = new System.Windows.Forms.Panel();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelEasy = new System.Windows.Forms.Panel();
            this.labelStatisticMiddl = new System.Windows.Forms.Label();
            this.labelStatisticEasy = new System.Windows.Forms.Label();
            this.panelStatistic.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatistic
            // 
            this.labelStatistic.AutoSize = true;
            this.labelStatistic.Font = new System.Drawing.Font("Trebuchet MS", 34F);
            this.labelStatistic.Location = new System.Drawing.Point(120, 9);
            this.labelStatistic.Name = "labelStatistic";
            this.labelStatistic.Size = new System.Drawing.Size(262, 57);
            this.labelStatistic.TabIndex = 1;
            this.labelStatistic.Text = "Статистика";
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.returnButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.returnButton.Location = new System.Drawing.Point(20, 24);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(44, 40);
            this.returnButton.TabIndex = 15;
            this.returnButton.Text = "<";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // panelStatistic
            // 
            this.panelStatistic.AutoScroll = true;
            this.panelStatistic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatistic.Controls.Add(this.labelScore3);
            this.panelStatistic.Controls.Add(this.labelMistakes3);
            this.panelStatistic.Controls.Add(this.labelTime3);
            this.panelStatistic.Controls.Add(this.labelScore2);
            this.panelStatistic.Controls.Add(this.labelMistakes2);
            this.panelStatistic.Controls.Add(this.labelTime2);
            this.panelStatistic.Controls.Add(this.labelScore1);
            this.panelStatistic.Controls.Add(this.labelMistakes1);
            this.panelStatistic.Controls.Add(this.labelTime1);
            this.panelStatistic.Controls.Add(this.labelStatisticDifficult);
            this.panelStatistic.Controls.Add(this.panelDifficult);
            this.panelStatistic.Controls.Add(this.panelMiddle);
            this.panelStatistic.Controls.Add(this.panelEasy);
            this.panelStatistic.Controls.Add(this.labelStatisticMiddl);
            this.panelStatistic.Controls.Add(this.labelStatisticEasy);
            this.panelStatistic.Location = new System.Drawing.Point(63, 95);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(356, 498);
            this.panelStatistic.TabIndex = 16;
            // 
            // labelScore3
            // 
            this.labelScore3.AutoSize = true;
            this.labelScore3.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.labelScore3.Location = new System.Drawing.Point(255, 361);
            this.labelScore3.Name = "labelScore3";
            this.labelScore3.Size = new System.Drawing.Size(49, 18);
            this.labelScore3.TabIndex = 16;
            this.labelScore3.Text = "Время";
            // 
            // labelMistakes3
            // 
            this.labelMistakes3.AutoSize = true;
            this.labelMistakes3.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.labelMistakes3.Location = new System.Drawing.Point(142, 361);
            this.labelMistakes3.Name = "labelMistakes3";
            this.labelMistakes3.Size = new System.Drawing.Size(49, 18);
            this.labelMistakes3.TabIndex = 15;
            this.labelMistakes3.Text = "Время";
            // 
            // labelTime3
            // 
            this.labelTime3.AutoSize = true;
            this.labelTime3.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.labelTime3.Location = new System.Drawing.Point(43, 361);
            this.labelTime3.Name = "labelTime3";
            this.labelTime3.Size = new System.Drawing.Size(49, 18);
            this.labelTime3.TabIndex = 14;
            this.labelTime3.Text = "Время";
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.labelScore2.Location = new System.Drawing.Point(255, 201);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(49, 18);
            this.labelScore2.TabIndex = 13;
            this.labelScore2.Text = "Время";
            // 
            // labelMistakes2
            // 
            this.labelMistakes2.AutoSize = true;
            this.labelMistakes2.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.labelMistakes2.Location = new System.Drawing.Point(142, 201);
            this.labelMistakes2.Name = "labelMistakes2";
            this.labelMistakes2.Size = new System.Drawing.Size(66, 18);
            this.labelMistakes2.TabIndex = 12;
            this.labelMistakes2.Text = "Помилок";
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.labelTime2.Location = new System.Drawing.Point(43, 201);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(49, 18);
            this.labelTime2.TabIndex = 11;
            this.labelTime2.Text = "Время";
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.labelScore1.Location = new System.Drawing.Point(255, 41);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(60, 18);
            this.labelScore1.TabIndex = 10;
            this.labelScore1.Text = "Рахунок";
            // 
            // labelMistakes1
            // 
            this.labelMistakes1.AutoSize = true;
            this.labelMistakes1.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.labelMistakes1.Location = new System.Drawing.Point(142, 41);
            this.labelMistakes1.Name = "labelMistakes1";
            this.labelMistakes1.Size = new System.Drawing.Size(59, 18);
            this.labelMistakes1.TabIndex = 9;
            this.labelMistakes1.Text = "Ошибок";
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.labelTime1.Location = new System.Drawing.Point(43, 41);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(49, 18);
            this.labelTime1.TabIndex = 8;
            this.labelTime1.Text = "Время";
            // 
            // labelStatisticDifficult
            // 
            this.labelStatisticDifficult.AutoSize = true;
            this.labelStatisticDifficult.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelStatisticDifficult.Location = new System.Drawing.Point(112, 332);
            this.labelStatisticDifficult.Name = "labelStatisticDifficult";
            this.labelStatisticDifficult.Size = new System.Drawing.Size(130, 35);
            this.labelStatisticDifficult.TabIndex = 4;
            this.labelStatisticDifficult.Text = "Сложный";
            // 
            // panelDifficult
            // 
            this.panelDifficult.AutoScroll = true;
            this.panelDifficult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDifficult.Location = new System.Drawing.Point(24, 382);
            this.panelDifficult.Name = "panelDifficult";
            this.panelDifficult.Size = new System.Drawing.Size(307, 88);
            this.panelDifficult.TabIndex = 7;
            // 
            // panelMiddle
            // 
            this.panelMiddle.AutoScroll = true;
            this.panelMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMiddle.Location = new System.Drawing.Point(24, 222);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(307, 88);
            this.panelMiddle.TabIndex = 6;
            // 
            // panelEasy
            // 
            this.panelEasy.AutoScroll = true;
            this.panelEasy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEasy.Location = new System.Drawing.Point(24, 62);
            this.panelEasy.Name = "panelEasy";
            this.panelEasy.Size = new System.Drawing.Size(307, 88);
            this.panelEasy.TabIndex = 5;
            // 
            // labelStatisticMiddl
            // 
            this.labelStatisticMiddl.AutoSize = true;
            this.labelStatisticMiddl.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelStatisticMiddl.Location = new System.Drawing.Point(112, 166);
            this.labelStatisticMiddl.Name = "labelStatisticMiddl";
            this.labelStatisticMiddl.Size = new System.Drawing.Size(122, 35);
            this.labelStatisticMiddl.TabIndex = 3;
            this.labelStatisticMiddl.Text = "Средний";
            // 
            // labelStatisticEasy
            // 
            this.labelStatisticEasy.AutoSize = true;
            this.labelStatisticEasy.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelStatisticEasy.Location = new System.Drawing.Point(121, 6);
            this.labelStatisticEasy.Name = "labelStatisticEasy";
            this.labelStatisticEasy.Size = new System.Drawing.Size(104, 35);
            this.labelStatisticEasy.TabIndex = 2;
            this.labelStatisticEasy.Text = "Легкий";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 605);
            this.Controls.Add(this.panelStatistic);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.labelStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormStatistic";
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            this.panelStatistic.ResumeLayout(false);
            this.panelStatistic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatistic;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.Label labelStatisticDifficult;
        private System.Windows.Forms.Label labelStatisticMiddl;
        private System.Windows.Forms.Label labelStatisticEasy;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Panel panelEasy;
        private System.Windows.Forms.Panel panelDifficult;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Label labelScore3;
        private System.Windows.Forms.Label labelMistakes3;
        private System.Windows.Forms.Label labelTime3;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Label labelMistakes2;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelMistakes1;
    }
}