namespace Gunchenko_Sudoku
{
    partial class WinForm
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
            this.labelWin = new System.Windows.Forms.Label();
            this.labelScoreInt = new System.Windows.Forms.Label();
            this.labelMistakesInt = new System.Windows.Forms.Label();
            this.labelTimeInt = new System.Windows.Forms.Label();
            this.labelModeName = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelMistakes = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Trebuchet MS", 28F);
            this.labelWin.Location = new System.Drawing.Point(210, 25);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(150, 49);
            this.labelWin.TabIndex = 21;
            this.labelWin.Text = "Победа";
            // 
            // labelScoreInt
            // 
            this.labelScoreInt.AutoSize = true;
            this.labelScoreInt.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScoreInt.Location = new System.Drawing.Point(326, 330);
            this.labelScoreInt.Name = "labelScoreInt";
            this.labelScoreInt.Size = new System.Drawing.Size(52, 29);
            this.labelScoreInt.TabIndex = 22;
            this.labelScoreInt.Text = "100";
            // 
            // labelMistakesInt
            // 
            this.labelMistakesInt.AutoSize = true;
            this.labelMistakesInt.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMistakesInt.Location = new System.Drawing.Point(326, 270);
            this.labelMistakesInt.Name = "labelMistakesInt";
            this.labelMistakesInt.Size = new System.Drawing.Size(26, 29);
            this.labelMistakesInt.TabIndex = 23;
            this.labelMistakesInt.Text = "0";
            // 
            // labelTimeInt
            // 
            this.labelTimeInt.AutoSize = true;
            this.labelTimeInt.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeInt.Location = new System.Drawing.Point(326, 210);
            this.labelTimeInt.Name = "labelTimeInt";
            this.labelTimeInt.Size = new System.Drawing.Size(48, 29);
            this.labelTimeInt.TabIndex = 24;
            this.labelTimeInt.Text = "0:0";
            // 
            // labelModeName
            // 
            this.labelModeName.AutoSize = true;
            this.labelModeName.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModeName.Location = new System.Drawing.Point(326, 150);
            this.labelModeName.Name = "labelModeName";
            this.labelModeName.Size = new System.Drawing.Size(89, 29);
            this.labelModeName.TabIndex = 25;
            this.labelModeName.Text = "Легкая";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(144, 330);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(99, 29);
            this.labelScore.TabIndex = 26;
            this.labelScore.Text = "Ошибок";
            // 
            // labelMistakes
            // 
            this.labelMistakes.AutoSize = true;
            this.labelMistakes.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMistakes.Location = new System.Drawing.Point(144, 270);
            this.labelMistakes.Name = "labelMistakes";
            this.labelMistakes.Size = new System.Drawing.Size(110, 29);
            this.labelMistakes.TabIndex = 27;
            this.labelMistakes.Text = "Помилок";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(144, 210);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(82, 29);
            this.labelTime.TabIndex = 28;
            this.labelTime.Text = "Время";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMode.Location = new System.Drawing.Point(144, 150);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(133, 29);
            this.labelMode.TabIndex = 29;
            this.labelMode.Text = "Сложность";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelResults.Location = new System.Drawing.Point(206, 95);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(156, 35);
            this.labelResults.TabIndex = 30;
            this.labelResults.Text = "Результаты";
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.buttonNewGame.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonNewGame.Location = new System.Drawing.Point(182, 388);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(180, 39);
            this.buttonNewGame.TabIndex = 31;
            this.buttonNewGame.Text = "Новая игра";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.buttonMenu.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonMenu.Location = new System.Drawing.Point(182, 443);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(180, 39);
            this.buttonMenu.TabIndex = 32;
            this.buttonMenu.Text = "Меню";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 505);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMistakes);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelModeName);
            this.Controls.Add(this.labelTimeInt);
            this.Controls.Add(this.labelMistakesInt);
            this.Controls.Add(this.labelScoreInt);
            this.Controls.Add(this.labelWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WinForm";
            this.Load += new System.EventHandler(this.WinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label labelScoreInt;
        private System.Windows.Forms.Label labelMistakesInt;
        private System.Windows.Forms.Label labelTimeInt;
        private System.Windows.Forms.Label labelModeName;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelMistakes;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonMenu;
    }
}