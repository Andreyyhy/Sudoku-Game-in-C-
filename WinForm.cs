using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gunchenko_Sudoku
{
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        private void ChangeTopic()
        {
            BackColor = FormMenu.light ? Color.FromArgb(230, 240, 255) : Color.FromArgb(50, 50, 80);
            labelWin.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelResults.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelMode.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelModeName.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelTime.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelTimeInt.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelMistakes.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelMistakesInt.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelScore.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelScoreInt.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);

            buttonNewGame.BackColor = FormMenu.light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            buttonMenu.BackColor = FormMenu.light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
        }

        private void ChangeLanguage()
        {
            labelWin.Text = FormMenu.ukrLang ? "Перемога!" : "Победа!";
            labelResults.Text = FormMenu.ukrLang ? "Результати:" : "Результаты:";
            labelMode.Text = FormMenu.ukrLang ? "Складність" : "Сложность";
            labelTime.Text = FormMenu.ukrLang ? "Час:" : "Время:";
            labelMistakes.Text = FormMenu.ukrLang ? "Помилок:" : "Ошибок:";
            labelScore.Text = FormMenu.ukrLang ? "Рахунок:" : "Счет:";

            buttonNewGame.Text = FormMenu.ukrLang ? "Нова гра" : "Новая игра";
        }

        private void WinForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            ChangeTopic();

            labelMistakesInt.Text = FormMenu.limitMistakes ? $"{Convert.ToString(Game.countMistakes)} / 3" : Convert.ToString(Game.countMistakes);
            labelScoreInt.Text = Convert.ToString(Game.score);
            labelTimeInt.Text = TimeSpan.FromSeconds(Game.seconds).ToString(@"mm\:ss");

            if (FormMenu.easyGame) labelModeName.Text = "Легкий";
            else if (FormMenu.middleGame) labelModeName.Text = FormMenu.ukrLang ? "Середній" : "Средний";
            else if (FormMenu.difficultGame) labelModeName.Text = FormMenu.ukrLang ? "Складний" : "Сложный";
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Hide();
        }
    }
}
