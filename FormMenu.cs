using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gunchenko_Sudoku
{
    public partial class FormMenu : Form //Форма меню
    {
        FormSettings settings = new FormSettings(); //Объвляем форму для настройки параметров игры
        FormStatistic statistic = new FormStatistic(); //Объявляем экземпляр формы статистики
        Game game = new Game(); //Объвляем экземпляр формы игры

        static public GameRule rule; //Объвление но пока без инициализации класса правила, для записи и чтения файла с настройками игры
       
        public static string FileName = @"GameRule.txt";//Статическая переменнаая с путем к файлу с настройками игры, доступный без создания экземпляра класса

        public static string FileNameWinEasy = @"Results\EasyResults.txt";//Статическая переменнаая с путем к файлу с результатами легкого уровня сложности открытая и статическая чтобы вызывть без создания экземляра
        
        public static string FileNameWinMiddle = @"Results\MiddleResults.txt";//Статическая переменнаая с путем к файлу с результатами среднего уровня сложности открытая и статическая чтобы вызывть без создания экземляра
        
        public static string FileNameWinDifficult = @"Results\DifficultResults.txt";//Статическая переменнаая с путем к файлу с результатами сложного уровня сложности открытая и статическая чтобы вызывть без создания экземляра

        public static bool light; //Объявление статической открытой булевой переменной для определение темы (светлая или темная)
        public static bool ukrLang;
        public static bool limitMistakes;
        public static bool easyGame;
        public static bool middleGame;
        public static bool difficultGame;
        public static bool continueGame; // Указывает, доступно ли продолжение игры

        private void ChangeTopic() //Метод для изменения темы главного меню
        {
            BackColor = light ? Color.FromArgb(230, 240, 255) : Color.FromArgb(50, 50, 80);
            labelSudoku.ForeColor = light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);

            continuegameButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            newgameButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            settingsButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            statisticButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            exitButton.BackColor = light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
        }

        private void ChangeLanguage() //Метод для изменения языка, такое-же выполнение как у метода изменения темы
        {
            continuegameButton.Text = ukrLang ? "Продовжити гру" : "Продолжить игру";
            newgameButton.Text = ukrLang ? "Нова гра" : "Новая игра";
            settingsButton.Text = ukrLang ? "Налаштування" : "Настройки";
            exitButton.Text = ukrLang ? "Вихід" : "Выход";
        }

        public FormMenu()
        {
            InitializeComponent();
            GameRule.ReadBoolFile(); //Сразу при запуске считается файл правил
            ChangeTopic(); //Изменяется тема
            ChangeLanguage(); //Изменяется язык
            continuegameButton.Visible = continueGame ? true : false; //Если стоит продолжить игру, то появляется соотвествующая кнопка
        }

        private void exitButton_Click(object sender, EventArgs e) //Собитие для кнопки выход, закрывается программа
        {
            Close();
        }

        private void settingsButton_Click(object sender, EventArgs e) //Событие для кнопки настроек
        {
            settings.ShowDialog(); //Открытие окна настройки в модальном режиме
            GameRule.ReadBoolFile(); //Считывается файл настроек для игры
            ChangeTopic(); //Вызов метода для изменения темы
            ChangeLanguage(); //Вызов метода для изменения языка
            continuegameButton.Visible = continueGame ? true : false; //Если в настройках менялись правила самой игры например режима, то кнопки продолжить не будет
        }

        private void statisticButton_Click(object sender, EventArgs e) //Событие клик для кнопки статистика
        {
            statistic.ShowDialog(); //Открытие формы статистики в модальном режими
        }

        private void newgameButton_Click(object sender, EventArgs e) //Событие клик для кнопки новая игра
        {
            rule = new GameRule(ukrLang, light, easyGame, middleGame, difficultGame, limitMistakes, false); //Обновление значений для создания игры
            game = new Game(); //Инициализация формы игры
            GameRule.ReadBoolFile(); //Чтение настроек игры
            DialogResult result = game.ShowDialog(); //Открытие модального окна формы игры, и при закрытии определение с каким результатом закрылось окно

            GameRule.ReadBoolFile(); //Чтение правил игры, если выиграл или проиграл то уже нельзя продолжить игру
            
            if (result == DialogResult.Yes) //Если результат удовлетворяет, то 
            {
                newgameButton_Click(sender, e); //Вызываем клик новой игры
            }

            continuegameButton.Visible = continueGame ? true : false; //Проверка можно продолжить игру или нет
        }

        private void continuegameButton_Click(object sender, EventArgs e) //Событие клик для кнопки продолжить игру, тело похожее на событие клин новая игра 
        {
            DialogResult result = game.ShowDialog();

            GameRule.ReadBoolFile();

            if (result == DialogResult.Yes)
            {
                newgameButton_Click(sender, e);
            }

            continuegameButton.Visible = continueGame ? true : false;
        }
    }
}
