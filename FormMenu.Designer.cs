namespace Gunchenko_Sudoku
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSudoku = new System.Windows.Forms.Label();
            this.newgameButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.statisticButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.continuegameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSudoku
            // 
            this.labelSudoku.AutoSize = true;
            this.labelSudoku.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSudoku.ForeColor = System.Drawing.Color.Silver;
            this.labelSudoku.Location = new System.Drawing.Point(121, 9);
            this.labelSudoku.Name = "labelSudoku";
            this.labelSudoku.Size = new System.Drawing.Size(241, 81);
            this.labelSudoku.TabIndex = 0;
            this.labelSudoku.Text = "Cудоку";
            // 
            // newgameButton
            // 
            this.newgameButton.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.newgameButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.newgameButton.Location = new System.Drawing.Point(88, 200);
            this.newgameButton.Name = "newgameButton";
            this.newgameButton.Size = new System.Drawing.Size(311, 44);
            this.newgameButton.TabIndex = 1;
            this.newgameButton.Text = "Новая игра";
            this.newgameButton.UseVisualStyleBackColor = true;
            this.newgameButton.Click += new System.EventHandler(this.newgameButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.settingsButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.settingsButton.Location = new System.Drawing.Point(88, 260);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(311, 44);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // statisticButton
            // 
            this.statisticButton.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.statisticButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.statisticButton.Location = new System.Drawing.Point(88, 320);
            this.statisticButton.Name = "statisticButton";
            this.statisticButton.Size = new System.Drawing.Size(311, 44);
            this.statisticButton.TabIndex = 3;
            this.statisticButton.Text = "Статистика";
            this.statisticButton.UseVisualStyleBackColor = true;
            this.statisticButton.Click += new System.EventHandler(this.statisticButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.exitButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.exitButton.Location = new System.Drawing.Point(88, 380);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(311, 44);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // continuegameButton
            // 
            this.continuegameButton.BackColor = System.Drawing.Color.Silver;
            this.continuegameButton.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.continuegameButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.continuegameButton.Location = new System.Drawing.Point(88, 140);
            this.continuegameButton.Name = "continuegameButton";
            this.continuegameButton.Size = new System.Drawing.Size(311, 44);
            this.continuegameButton.TabIndex = 5;
            this.continuegameButton.Text = "Продолжить игру";
            this.continuegameButton.UseVisualStyleBackColor = false;
            this.continuegameButton.Visible = false;
            this.continuegameButton.Click += new System.EventHandler(this.continuegameButton_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.continuegameButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.statisticButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.newgameButton);
            this.Controls.Add(this.labelSudoku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Судоку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSudoku;
        private System.Windows.Forms.Button newgameButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button statisticButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button continuegameButton;
    }
}

