namespace Gunchenko_Sudoku
{
    partial class LooseForm
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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.labelThreeMistakes = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelModeName = new System.Windows.Forms.Label();
            this.labelTimeInt = new System.Windows.Forms.Label();
            this.labelScoreInt = new System.Windows.Forms.Label();
            this.labelLoose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenu.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonMenu.Location = new System.Drawing.Point(193, 428);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(180, 39);
            this.buttonMenu.TabIndex = 44;
            this.buttonMenu.Text = "Меню";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonNewGame.Location = new System.Drawing.Point(193, 370);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(180, 39);
            this.buttonNewGame.TabIndex = 43;
            this.buttonNewGame.Text = "Новая игра";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // labelThreeMistakes
            // 
            this.labelThreeMistakes.AutoSize = true;
            this.labelThreeMistakes.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelThreeMistakes.Location = new System.Drawing.Point(198, 94);
            this.labelThreeMistakes.Name = "labelThreeMistakes";
            this.labelThreeMistakes.Size = new System.Drawing.Size(156, 35);
            this.labelThreeMistakes.TabIndex = 42;
            this.labelThreeMistakes.Text = "Результаты";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMode.Location = new System.Drawing.Point(155, 169);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(133, 29);
            this.labelMode.TabIndex = 41;
            this.labelMode.Text = "Сложность";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(155, 229);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(82, 29);
            this.labelTime.TabIndex = 40;
            this.labelTime.Text = "Время";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(155, 291);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(99, 29);
            this.labelScore.TabIndex = 38;
            this.labelScore.Text = "Ошибок";
            // 
            // labelModeName
            // 
            this.labelModeName.AutoSize = true;
            this.labelModeName.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModeName.Location = new System.Drawing.Point(337, 169);
            this.labelModeName.Name = "labelModeName";
            this.labelModeName.Size = new System.Drawing.Size(89, 29);
            this.labelModeName.TabIndex = 37;
            this.labelModeName.Text = "Легкая";
            // 
            // labelTimeInt
            // 
            this.labelTimeInt.AutoSize = true;
            this.labelTimeInt.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeInt.Location = new System.Drawing.Point(337, 229);
            this.labelTimeInt.Name = "labelTimeInt";
            this.labelTimeInt.Size = new System.Drawing.Size(48, 29);
            this.labelTimeInt.TabIndex = 36;
            this.labelTimeInt.Text = "0:0";
            // 
            // labelScoreInt
            // 
            this.labelScoreInt.AutoSize = true;
            this.labelScoreInt.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScoreInt.Location = new System.Drawing.Point(337, 291);
            this.labelScoreInt.Name = "labelScoreInt";
            this.labelScoreInt.Size = new System.Drawing.Size(52, 29);
            this.labelScoreInt.TabIndex = 34;
            this.labelScoreInt.Text = "100";
            // 
            // labelLoose
            // 
            this.labelLoose.AutoSize = true;
            this.labelLoose.Font = new System.Drawing.Font("Trebuchet MS", 28F);
            this.labelLoose.Location = new System.Drawing.Point(196, 23);
            this.labelLoose.Name = "labelLoose";
            this.labelLoose.Size = new System.Drawing.Size(150, 49);
            this.labelLoose.TabIndex = 33;
            this.labelLoose.Text = "Победа";
            // 
            // LooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 505);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.labelThreeMistakes);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelModeName);
            this.Controls.Add(this.labelTimeInt);
            this.Controls.Add(this.labelScoreInt);
            this.Controls.Add(this.labelLoose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LooseForm";
            this.Load += new System.EventHandler(this.LooseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label labelThreeMistakes;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelModeName;
        private System.Windows.Forms.Label labelTimeInt;
        private System.Windows.Forms.Label labelScoreInt;
        private System.Windows.Forms.Label labelLoose;
    }
}