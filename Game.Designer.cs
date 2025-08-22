namespace Gunchenko_Sudoku
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.returnButton = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonStopTime = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCountMistakes = new System.Windows.Forms.Label();
            this.labelCountMistakesInt = new System.Windows.Forms.Label();
            this.pictureBoxLastik = new System.Windows.Forms.PictureBox();
            this.labelScoreInt = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerScore = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastik)).BeginInit();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.returnButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.returnButton.Location = new System.Drawing.Point(12, 12);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(44, 40);
            this.returnButton.TabIndex = 16;
            this.returnButton.Text = "<";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelTime.Location = new System.Drawing.Point(267, 29);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(81, 35);
            this.labelTime.TabIndex = 17;
            this.labelTime.Text = "00:00";
            // 
            // buttonStopTime
            // 
            this.buttonStopTime.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.buttonStopTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonStopTime.Location = new System.Drawing.Point(206, 31);
            this.buttonStopTime.Name = "buttonStopTime";
            this.buttonStopTime.Size = new System.Drawing.Size(40, 32);
            this.buttonStopTime.TabIndex = 18;
            this.buttonStopTime.Text = "||";
            this.buttonStopTime.UseVisualStyleBackColor = true;
            this.buttonStopTime.Click += new System.EventHandler(this.buttonStopTime_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(150, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 350);
            this.panel1.TabIndex = 19;
            // 
            // labelCountMistakes
            // 
            this.labelCountMistakes.AutoSize = true;
            this.labelCountMistakes.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelCountMistakes.Location = new System.Drawing.Point(380, 9);
            this.labelCountMistakes.Name = "labelCountMistakes";
            this.labelCountMistakes.Size = new System.Drawing.Size(124, 35);
            this.labelCountMistakes.TabIndex = 20;
            this.labelCountMistakes.Text = "Помилок";
            // 
            // labelCountMistakesInt
            // 
            this.labelCountMistakesInt.AutoSize = true;
            this.labelCountMistakesInt.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelCountMistakesInt.Location = new System.Drawing.Point(510, 11);
            this.labelCountMistakesInt.Name = "labelCountMistakesInt";
            this.labelCountMistakesInt.Size = new System.Drawing.Size(0, 35);
            this.labelCountMistakesInt.TabIndex = 21;
            // 
            // pictureBoxLastik
            // 
            this.pictureBoxLastik.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLastik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLastik.Image = global::Gunchenko_Sudoku.Properties.Resources.Lastik;
            this.pictureBoxLastik.Location = new System.Drawing.Point(499, 392);
            this.pictureBoxLastik.Name = "pictureBoxLastik";
            this.pictureBoxLastik.Size = new System.Drawing.Size(48, 40);
            this.pictureBoxLastik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLastik.TabIndex = 22;
            this.pictureBoxLastik.TabStop = false;
            this.pictureBoxLastik.Click += new System.EventHandler(this.pictureBoxLastik_Click);
            // 
            // labelScoreInt
            // 
            this.labelScoreInt.AutoSize = true;
            this.labelScoreInt.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelScoreInt.Location = new System.Drawing.Point(510, 44);
            this.labelScoreInt.Name = "labelScoreInt";
            this.labelScoreInt.Size = new System.Drawing.Size(0, 35);
            this.labelScoreInt.TabIndex = 24;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.labelScore.Location = new System.Drawing.Point(380, 42);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(115, 35);
            this.labelScore.TabIndex = 23;
            this.labelScore.Text = "Рахунок";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerScore
            // 
            this.timerScore.Interval = 1000;
            this.timerScore.Tick += new System.EventHandler(this.timerScore_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 529);
            this.Controls.Add(this.labelScoreInt);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxLastik);
            this.Controls.Add(this.labelCountMistakesInt);
            this.Controls.Add(this.labelCountMistakes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStopTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.returnButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonStopTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCountMistakes;
        private System.Windows.Forms.Label labelCountMistakesInt;
        private System.Windows.Forms.PictureBox pictureBoxLastik;
        private System.Windows.Forms.Label labelScoreInt;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerScore;
    }
}