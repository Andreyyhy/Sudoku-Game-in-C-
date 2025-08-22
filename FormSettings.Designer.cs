namespace Gunchenko_Sudoku
{
    partial class FormSettings
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
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelTopic = new System.Windows.Forms.Label();
            this.lightButton = new System.Windows.Forms.Button();
            this.labelModegame = new System.Windows.Forms.Label();
            this.easygameButton = new System.Windows.Forms.Button();
            this.middlegameButton = new System.Windows.Forms.Button();
            this.difficultgameButton = new System.Windows.Forms.Button();
            this.checkBoxMistakes = new System.Windows.Forms.CheckBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.russianButton = new System.Windows.Forms.Button();
            this.ukrainianButton = new System.Windows.Forms.Button();
            this.darkButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Trebuchet MS", 34F);
            this.labelSettings.Location = new System.Drawing.Point(112, 10);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(250, 57);
            this.labelSettings.TabIndex = 0;
            this.labelSettings.Text = "Настройки";
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelTopic.Location = new System.Drawing.Point(200, 80);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(79, 35);
            this.labelTopic.TabIndex = 1;
            this.labelTopic.Text = "Тема";
            // 
            // lightButton
            // 
            this.lightButton.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.lightButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.lightButton.Location = new System.Drawing.Point(110, 125);
            this.lightButton.Name = "lightButton";
            this.lightButton.Size = new System.Drawing.Size(110, 40);
            this.lightButton.TabIndex = 2;
            this.lightButton.Text = "Светлая";
            this.lightButton.UseVisualStyleBackColor = true;
            this.lightButton.Click += new System.EventHandler(this.lightButton_Click);
            // 
            // labelModegame
            // 
            this.labelModegame.AutoSize = true;
            this.labelModegame.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelModegame.Location = new System.Drawing.Point(128, 190);
            this.labelModegame.Name = "labelModegame";
            this.labelModegame.Size = new System.Drawing.Size(239, 35);
            this.labelModegame.TabIndex = 4;
            this.labelModegame.Text = "Режим сложности";
            // 
            // easygameButton
            // 
            this.easygameButton.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.easygameButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.easygameButton.Location = new System.Drawing.Point(83, 249);
            this.easygameButton.Name = "easygameButton";
            this.easygameButton.Size = new System.Drawing.Size(340, 50);
            this.easygameButton.TabIndex = 5;
            this.easygameButton.Text = "Легкий";
            this.easygameButton.UseVisualStyleBackColor = true;
            this.easygameButton.Click += new System.EventHandler(this.easygameButton_Click);
            // 
            // middlegameButton
            // 
            this.middlegameButton.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.middlegameButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.middlegameButton.Location = new System.Drawing.Point(83, 309);
            this.middlegameButton.Name = "middlegameButton";
            this.middlegameButton.Size = new System.Drawing.Size(340, 50);
            this.middlegameButton.TabIndex = 6;
            this.middlegameButton.Text = "Средний";
            this.middlegameButton.UseVisualStyleBackColor = true;
            this.middlegameButton.Click += new System.EventHandler(this.middlegameButton_Click);
            // 
            // difficultgameButton
            // 
            this.difficultgameButton.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.difficultgameButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.difficultgameButton.Location = new System.Drawing.Point(83, 369);
            this.difficultgameButton.Name = "difficultgameButton";
            this.difficultgameButton.Size = new System.Drawing.Size(340, 50);
            this.difficultgameButton.TabIndex = 7;
            this.difficultgameButton.Text = "Сложный";
            this.difficultgameButton.UseVisualStyleBackColor = true;
            this.difficultgameButton.Click += new System.EventHandler(this.difficultgameButton_Click);
            // 
            // checkBoxMistakes
            // 
            this.checkBoxMistakes.AutoSize = true;
            this.checkBoxMistakes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMistakes.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.checkBoxMistakes.Location = new System.Drawing.Point(120, 440);
            this.checkBoxMistakes.Name = "checkBoxMistakes";
            this.checkBoxMistakes.Size = new System.Drawing.Size(236, 39);
            this.checkBoxMistakes.TabIndex = 9;
            this.checkBoxMistakes.Text = "Лимит 3 ошибки";
            this.checkBoxMistakes.UseVisualStyleBackColor = true;
            this.checkBoxMistakes.CheckedChanged += new System.EventHandler(this.checkBoxMistakes_CheckedChanged);
            this.checkBoxMistakes.Click += new System.EventHandler(this.checkBoxMistakes_Click);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelLanguage.Location = new System.Drawing.Point(200, 480);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(76, 35);
            this.labelLanguage.TabIndex = 10;
            this.labelLanguage.Text = "Язык";
            // 
            // russianButton
            // 
            this.russianButton.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.russianButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.russianButton.Location = new System.Drawing.Point(64, 527);
            this.russianButton.Name = "russianButton";
            this.russianButton.Size = new System.Drawing.Size(156, 50);
            this.russianButton.TabIndex = 11;
            this.russianButton.Text = "Русский";
            this.russianButton.UseVisualStyleBackColor = true;
            this.russianButton.Click += new System.EventHandler(this.russianButton_Click);
            // 
            // ukrainianButton
            // 
            this.ukrainianButton.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.ukrainianButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.ukrainianButton.Location = new System.Drawing.Point(258, 527);
            this.ukrainianButton.Name = "ukrainianButton";
            this.ukrainianButton.Size = new System.Drawing.Size(156, 50);
            this.ukrainianButton.TabIndex = 12;
            this.ukrainianButton.Text = "Украинский";
            this.ukrainianButton.UseVisualStyleBackColor = true;
            this.ukrainianButton.Click += new System.EventHandler(this.ukrainianButton_Click);
            // 
            // darkButton
            // 
            this.darkButton.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.darkButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.darkButton.Location = new System.Drawing.Point(258, 125);
            this.darkButton.Name = "darkButton";
            this.darkButton.Size = new System.Drawing.Size(110, 40);
            this.darkButton.TabIndex = 13;
            this.darkButton.Text = "Темная";
            this.darkButton.UseVisualStyleBackColor = true;
            this.darkButton.Click += new System.EventHandler(this.darkButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.returnButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.returnButton.Location = new System.Drawing.Point(20, 24);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(42, 40);
            this.returnButton.TabIndex = 14;
            this.returnButton.Text = "<";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 605);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.darkButton);
            this.Controls.Add(this.ukrainianButton);
            this.Controls.Add(this.russianButton);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.checkBoxMistakes);
            this.Controls.Add(this.difficultgameButton);
            this.Controls.Add(this.middlegameButton);
            this.Controls.Add(this.easygameButton);
            this.Controls.Add(this.labelModegame);
            this.Controls.Add(this.lightButton);
            this.Controls.Add(this.labelTopic);
            this.Controls.Add(this.labelSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Button lightButton;
        private System.Windows.Forms.Label labelModegame;
        private System.Windows.Forms.Button easygameButton;
        private System.Windows.Forms.Button middlegameButton;
        private System.Windows.Forms.Button difficultgameButton;
        private System.Windows.Forms.CheckBox checkBoxMistakes;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Button russianButton;
        private System.Windows.Forms.Button ukrainianButton;
        private System.Windows.Forms.Button darkButton;
        private System.Windows.Forms.Button returnButton;
    }
}