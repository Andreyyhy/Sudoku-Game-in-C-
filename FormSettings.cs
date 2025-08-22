using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gunchenko_Sudoku
{
    public partial class FormSettings : Form //Форма настроек
    {

        bool light; //Собственные булевые переменные для данной формы
        bool ukrLang;
        bool limitMistakes;
        bool easyGame;
        bool middleGame;
        bool difficultGame;
        bool continueGame;

        private void ReadBoolean() //Метод инициализации булевых переменных
        {
            light = FormMenu.light; //Присваивается такое-же значение как у главного меню
            ukrLang = FormMenu.ukrLang;
            limitMistakes = FormMenu.limitMistakes;
            easyGame = FormMenu.easyGame;
            middleGame = FormMenu.middleGame;
            difficultGame = FormMenu.difficultGame;
            continueGame = FormMenu.continueGame;
        } 

        public FormSettings()
        {
            InitializeComponent();
        }

        private void ChangeTopic()
        {
            BackColor = light ? Color.FromArgb(230, 240, 255) : Color.FromArgb(50, 50, 80);

            labelSettings.ForeColor = light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelTopic.ForeColor = light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelModegame.ForeColor = light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            checkBoxMistakes.ForeColor = light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelLanguage.ForeColor = light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);

            lightButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            darkButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            easygameButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            middlegameButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            difficultgameButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            russianButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            ukrainianButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            returnButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
        }
        private void SelectedButtons() //Метод для презентацию пользователя какие настройки выбранны
        {
            if (light) //Если светлая тема то будет меняться на зеленный или белый
            {
                lightButton.BackColor = light ? Color.LightGreen : Color.FromArgb(180, 220, 255);
                easygameButton.BackColor = easyGame ? Color.LightGreen : Color.FromArgb(180, 220, 255);
                middlegameButton.BackColor = middleGame ? Color.LightGreen : Color.FromArgb(180, 220, 255);
                difficultgameButton.BackColor = difficultGame ? Color.LightGreen : Color.FromArgb(180, 220, 255);
                russianButton.BackColor = !ukrLang ? Color.LightGreen : Color.FromArgb(180, 220, 255);
                ukrainianButton.BackColor = ukrLang ? Color.LightGreen : Color.FromArgb(180, 220, 255);
            }
            else //Если темная то зеленый и темный
            {
                darkButton.BackColor = !light ? Color.LightGreen : Color.FromArgb(100, 100, 150);
                easygameButton.BackColor = easyGame ? Color.LightGreen : Color.FromArgb(100, 100, 150);
                middlegameButton.BackColor = middleGame ? Color.LightGreen : Color.FromArgb(100, 100, 150);
                difficultgameButton.BackColor = difficultGame ? Color.LightGreen : Color.FromArgb(100, 100, 150);
                russianButton.BackColor = !ukrLang ? Color.LightGreen : Color.FromArgb(100, 100, 150);
                ukrainianButton.BackColor = ukrLang ? Color.LightGreen : Color.FromArgb(100, 100, 150);
            }
        }

        private void ChangeLanguage() //Метод изменяет язык текстовых элементов формы
        {
            labelSettings.Text = ukrLang ? "Налаштування" : "Настройки";
            lightButton.Text = ukrLang ? "Світла" : "Светлая";
            darkButton.Text = ukrLang ? "Темна" : "Темная";
            labelModegame.Text = ukrLang ? "Режим складності" : "Режим сложности";
            middlegameButton.Text = ukrLang ? "Середній" : "Средний";
            difficultgameButton.Text = ukrLang ? "Складний" : "Сложный";
            checkBoxMistakes.Text = ukrLang ? "Ліміт 3 помилки" : "Лимит 3 ошибки";
            labelLanguage.Text = ukrLang ? "Мова" : "Язык";
            russianButton.Text = ukrLang ? "Російська" : "Русский";
            ukrainianButton.Text = ukrLang ? "Українська" : "Украинский";
        }

        private void returnButton_Click(object sender, EventArgs e) //Собите клика по кнопке вернуться
        {
            FormMenu.rule = new GameRule(ukrLang, light, easyGame, middleGame, difficultGame, limitMistakes, continueGame); //Перезапись файла с настройками игры
            Hide(); //Закрытие формы
        }

        private void darkButton_Click(object sender, EventArgs e) //Событие клика по кнопке темная тема
        {
            light = false; //Присвоение False, не светлая тема
            ChangeTopic(); //Вызов метод для изменнения темы
            SelectedButtons(); //Вызов метода для презентации пользователю что выбрано
        }

        private void lightButton_Click(object sender, EventArgs e) //Собите клика по кнопке светлая тема, тело похожее с телом темной темы
        {
            light = true;
            ChangeTopic();
            SelectedButtons();
        }

        private void FormSettings_Load(object sender, EventArgs e) //При загрузки формы
        {
            ReadBoolean(); //Инициализация белевых полей

            ChangeTopic(); //Изменение темы

            ChangeLanguage(); //Изменение языка

            checkBoxMistakes.Checked = limitMistakes ? true : false; //Выбран или нет лимит ошибок

            SelectedButtons(); //Информация для пользователя какие настройки выбраны
        }

        private void russianButton_Click(object sender, EventArgs e) //Клик кнопки смены языка на русский
        {
            ukrLang = false;
            ChangeLanguage();

            SelectedButtons();
        }

        private void ukrainianButton_Click(object sender, EventArgs e) //Клик на кнопку семны языка на украинский
        {
            ukrLang = true;
            ChangeLanguage();

            SelectedButtons();
        }

        private void easygameButton_Click(object sender, EventArgs e) //Смена режима игры на легкий
        {
            easyGame = true;
            middleGame = false;
            difficultGame = false;
            continueGame = false;
            SelectedButtons();
        }

        private void middlegameButton_Click(object sender, EventArgs e) //Смена режима на средний
        {
            easyGame = false;
            middleGame = true;
            difficultGame = false;
            continueGame = false;
            SelectedButtons();
        }

        private void difficultgameButton_Click(object sender, EventArgs e) //Смена режима на тяжелый
        {
            easyGame = false;
            middleGame = false;
            difficultGame = true;
            continueGame = false;
            SelectedButtons();
        }

        private void checkBoxMistakes_CheckedChanged(object sender, EventArgs e) //Изменение правил для лимита ошибок
        {                
            if (checkBoxMistakes.Checked)
                limitMistakes = true;
            else
                limitMistakes = false;
        }

        private void checkBoxMistakes_Click(object sender, EventArgs e) //Если меняется правило лимита ошибок, нельзя продолжить игру
        {
            continueGame = false;
        }
    }
}
