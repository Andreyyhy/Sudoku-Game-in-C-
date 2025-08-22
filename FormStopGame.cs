using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gunchenko_Sudoku
{
    public partial class FormStopGame : Form
    {
        public FormStopGame()
        {
            InitializeComponent();
        }

        private void ChangeTopic()
        {
            BackColor = FormMenu.light ? Color.FromArgb(230, 240, 255) : Color.FromArgb(50, 50, 80);
            buttonContinue.BackColor = FormMenu.light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            labelTime.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelStop.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelMode.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelTime.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelMistakes.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelMistakesInt.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelTimeInt.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelModeName.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelScoreInt.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelScore.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
        }

        private void ChangeLanguage()
        {
            labelMode.Text = FormMenu.ukrLang ? "Складність" : "Сложность";
            labelTime.Text = FormMenu.ukrLang ? "Час" : "Время";
            labelMistakes.Text = FormMenu.ukrLang ? "Помилок" : "Ошибок";
            buttonContinue.Text = FormMenu.ukrLang ? "Продовжити" : "Продолжить";
            labelScore.Text = FormMenu.ukrLang ? "Рахунок" : "Счёт";
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FormStopGame_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            ChangeTopic();
            labelMistakesInt.Text = FormMenu.limitMistakes ? $"{Convert.ToString(Game.countMistakes)} / 3" : Convert.ToString(Game.countMistakes);
            labelTimeInt.Text = TimeSpan.FromSeconds(Game.seconds).ToString(@"mm\:ss");
            labelScoreInt.Text = Convert.ToString(Game.score);
            if (FormMenu.easyGame) labelModeName.Text = "Легкий";
            else if (FormMenu.middleGame) labelModeName.Text = FormMenu.ukrLang ? "Середній" : "Средний";
            else if (FormMenu.difficultGame) labelModeName.Text = FormMenu.ukrLang ? "Складний" : "Сложный";
        }
    }
}
