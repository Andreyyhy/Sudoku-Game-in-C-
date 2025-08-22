using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gunchenko_Sudoku
{
    public partial class Game : Form //Форма игры
    {
        ReadWriteGame readWriteGame = new ReadWriteGame(); //Класс для записи и чтения игры

        GenerationGame generationGame = new GenerationGame(); //Клас для генерации игры

        ReadWriteWinResults readWriteWinResults = new ReadWriteWinResults(); //Класс для записи выигранной игры

        WinForm winForm = new WinForm(); //Форма выиграш

        LooseForm looseForm = new LooseForm(); //Форма проигрыщ

        TextBox selectedTextBox; //Объвление выделеного текст бокса

        public static int n = 3; //Открытое статическое поле, количество блоков

        int selectedTextBoxI;  //Переменная для выделенного i j текст бокса 
        int selectedTextBoxJ;

        public static int score; //Счет 

        public static int ScoreTime; //Время с предыдущего изменения счета

        public static int countMaps = 18; //Количество карт судоку 

        public static string ReadFilePath = @"Maps\Solution";//Неполный путь для чтение решения судоку

        public static string WriteFilePath = @"SolutionGame.txt";//Путь для записи решения судоку

        public static string WriteResultFilePath = @"ResultGame.txt";//Путь для записи что открыто и какие есть значения игры

        public static TextBox[,] grid = new TextBox[n * n, n * n]; //Масив текст боксов 

        public static int[,] solution = new int[n * n, n * n]; //Масив решения судоку

        public static bool[,] solutionBool = new bool[n * n, n * n]; //Масив какие текст бокс видны какие нет

        private int scoreMultiplier;
        
        Button[] buttons = new Button[9]; //Масив кнопок

        Random random = new Random(); //Рандомайзер

        FormStopGame stopGame = new FormStopGame(); //Форма пауза

        public static int seconds; //Секунды
        public static int countMistakes; //Количество ошибок

        public static int HideTextBoxes; //Количество скрытых текст боксов (на которых ничего не написано)

        private void SetButtons() //Метод установки кнопок 1-9
        {
            int x = 30; //Начальная позиция х
            int y = 450; //Начальная позиция у
            for (int i = 0; i < 9; i++)
            {
                buttons[i] = new Button(); //Инициализация кнопки
                buttons[i].Size = new Size(48, 46); //Установка размера
                buttons[i].Location = new Point(x, y); //Местоположение
                buttons[i].Click += buttonNumber_Click; //Подключение собития клик
                buttons[i].Text = Convert.ToString(i + 1); //Текст кнопок
                buttons[i].ForeColor = Color.DarkBlue;
                buttons[i].Font = new Font("Trebuchet MS", 20f); //Шрифт и размер
                x += 58; //Изминение х
            }
            Controls.AddRange(buttons); //Добавление массива кнопок на форму
        }

        private void SetTextBoxes(bool boolea) //Метод установки текст боксов
        {
            PictureBox pictureBox1 = new PictureBox(); //Установка picturebox, линия отделющая блоки
            pictureBox1.Size = new Size(2, 350); //Размер
            pictureBox1.BorderStyle = BorderStyle.FixedSingle; //Установка контура
            pictureBox1.Location = new Point(103, 0); //Местоположение
            panel1.Controls.Add(pictureBox1); //Добавление на панель

            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.Size = new Size(2, 350);
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(206, 0);
            panel1.Controls.Add(pictureBox2);

            PictureBox pictureBox3 = new PictureBox();
            pictureBox3.Size = new Size(312, 2);
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(0, 114);
            panel1.Controls.Add(pictureBox3);

            PictureBox pictureBox4 = new PictureBox();
            pictureBox4.Size = new Size(312, 2);
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(0, 228);
            panel1.Controls.Add(pictureBox4);

            int x, y = 4; //Первоначальный у
            for (int i = 0; i < n * n; i++)
            {
                x = 4; //Инициализация х
                for (int j = 0; j < n * n; j++)
                {
                    grid[i, j] = new TextBox(); //Иницилизация текст бокса
                    grid[i, j].Font = new Font("Trebuchet MS", 18f); //Установка шрифта и размера шрифта
                    grid[i, j].Size = new Size(30, 30); //Размер
                    grid[i, j].Click += TextBox_Click; //Событие клик
                    grid[i, j].KeyPress += TextBox_KeyPress; //Событие нажатие на кнопку клавиатуры
                    grid[i, j].TextAlign = HorizontalAlignment.Center; //Текст по центру
                    grid[i, j].Location = new Point(x, y); //Позиция
                    panel1.Controls.Add(grid[i, j]); //Добавление на панель
                    x += 34;
                }
                y += 38;
            }

            for (int i = 0; i < n * n; i++) //Проход по циклу для записи текста в текст боксы
            {
                for (int j = 0; j < n * n; j++)
                {
                    if (boolea)
                    {
                        if (solutionBool[i, j])
                            grid[i, j].Text = Convert.ToString(solution[i, j]);
                    }
                    else
                    {
                        grid[i, j].Text = Convert.ToString(solution[i, j]);
                    }
                }
            }
        }

        private void TextBoxReadOnly() //Метод для установки текст бокса ReadOnly
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    grid[i, j].ReadOnly = solutionBool[i, j]; //Проверяет по булевуму массиву
                }
            }
        }

        private void ChangeTopic() //Изменение цвета формы
        {
            BackColor = FormMenu.light ? Color.FromArgb(230, 240, 255) : Color.FromArgb(50, 50, 80);
            buttonStopTime.BackColor = FormMenu.light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            labelTime.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelCountMistakes.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelCountMistakesInt.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            returnButton.BackColor = FormMenu.light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            labelScore.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelScoreInt.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            panel1.BackColor = Color.White;
            for (int i = 0; i < 9; i++)
            {
                buttons[i].BackColor = FormMenu.light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
            }
        }

        private void ChangeLanguage() //Изменение языка формы
        {
            labelCountMistakes.Text = FormMenu.ukrLang ? "Помилок" : "Ошибок";
            labelScore.Text = FormMenu.ukrLang ? "Рахунок" : "Счёт";
        }

        public Game()
        {
            InitializeComponent();
            SetButtons(); //Установка кнопок 1-9
        }

        private void returnButton_Click(object sender, EventArgs e) //Собитие клик выход
        {
            timer1.Stop(); //Останавливается таймер
            timerScore.Stop();
            readWriteGame.WriteResults(WriteResultFilePath); //Перезаписывает файл решения
            FormMenu.rule = new GameRule(FormMenu.ukrLang, FormMenu.light, FormMenu.easyGame, FormMenu.middleGame, FormMenu.difficultGame, FormMenu.limitMistakes, true); //Перезаписывает файл настроек игры
            Hide();
        }

        private void Game_Load(object sender, EventArgs e) //Событие загрузки формы
        {
            ChangeTopic(); //Изменение цвета формы
            ChangeLanguage(); //Изменеие языка

            panel1.Controls.Clear(); //Ощищение панели для правильности работы

            if (FormMenu.easyGame) scoreMultiplier = 1;
            else if (FormMenu.middleGame) scoreMultiplier = 5;
            else if (FormMenu.difficultGame) scoreMultiplier = 10;

            if (!FormMenu.continueGame) //Если игра не продолжается
            {
                timer1.Enabled = false; //Остановка таймера перед сбросом
                timerScore.Enabled = false; //Остановка таймера для счета
                timer1.Stop(); //Остановка таймера
                timerScore.Stop(); //Остановка таймера для счета
                seconds = 0; //Сброс времени
                ScoreTime = 0; //Сброс времени с последнего изменения счета
                labelTime.Text = "00:00"; //Отображение времени "00:00"
                timer1.Interval = 1000; //Установка интервала таймера
                timerScore.Interval = 1000; //Установка интервала таймера для счета
                timer1.Start(); //Запуск таймера
                timerScore.Start(); //Запуск таймера для счета
                score = 0; //Сброс счета
                countMistakes = 0; //Сброс ошибок

                generationGame.GenerateGame(); //Генерация игры
                SetTextBoxes(false); //Вставка текст боксов, передается что не продолжение
                generationGame.HideTexts(); //Сокрытие текст боксов
                TextBoxReadOnly(); //Установка текст боксам для чтения или не
            }
            else
            {
                readWriteGame.Read(WriteFilePath); //Чтение решения
                readWriteGame.ReadResults(WriteResultFilePath); //Чтение булевого решения
                SetTextBoxes(true); //Установка текст боксов, передается что продолжение игры
                TextBoxReadOnly(); //Установка текст боксам для чтения или нет
                timer1.Stop(); //Остановка таймера
                timerScore.Stop(); //Остановка таймера для счета
                timer1.Interval = 1000; //Установка интервала таймера
                timerScore.Interval = 1000; //Установка интервала таймера для счета
                timer1.Start(); //Запуск таймера
                timerScore.Start(); //Запуск таймера для счета

                for (int i = 1; i <= 9; i++)
                {
                    UpdateButtonVisibility(i); //Проверка для каждой кнопки видна она или нет
                }
            }

            UpdateCountMistakes(); //Обновление информации про ошибка 
            UpdateScore(); //Обновление информации про счет
        }

        private void timer1_Tick(object sender, EventArgs e) //Тик секундомера
        {
            seconds++; // Увеличиваем счетчик секунд
            labelTime.Text = TimeSpan.FromSeconds(seconds).ToString(@"mm\:ss"); // Обновляем лейбл
        }

        private void buttonStopTime_Click(object sender, EventArgs e) //Кнопка пауза клик
        {
            timer1.Stop(); //Остановка таймера
            timerScore.Stop(); //Остановка таймера для счета
            stopGame.ShowDialog(); //Открытие модального окна паузы
            timer1.Start(); //Возобновление таймера
            timerScore.Start(); //Возобновление таймера для счета
        }

        private void buttonNumber_Click(object sender, EventArgs e) //Нажатие на кнопку
        {
            Button btn = (Button)sender; //Определяет, какое число выбрал игрок

            if (selectedTextBox == null || selectedTextBox.ReadOnly) //Предотвращает ввод числа, если игрок не выбрал ячейку или ячейка недоступна для изменения
            {
                return;
            }

            selectedTextBox.Text = btn.Text; //Позволяет игроку ввести число в ячейку игрового поля

            SelectedIJ(); // Определяет индексы выбранной ячейки в игровом поле
            if (selectedTextBoxI > -1 && selectedTextBoxJ > -1 && solution[selectedTextBoxI, selectedTextBoxJ] == Convert.ToInt32(btn.Text)) // Проверяет правильно ли введенное число сравнивая с решением
            {
                // Помечает ячейку как правильно заполненную
                grid[selectedTextBoxI, selectedTextBoxJ].BackColor = Color.FromArgb(240, 240, 240);
                grid[selectedTextBoxI, selectedTextBoxJ].ReadOnly = true;
                solutionBool[selectedTextBoxI, selectedTextBoxJ] = true;
                readWriteGame.WriteResults(WriteResultFilePath); //Перезаписывает файл
                TextBoxReadOnly(); // Обновляет статус редактирования всех ячеек

                UpdateButtonVisibility(Convert.ToInt32(btn.Text)); // Скрывает кнопку если все есть на форме

                // Начисляет очки в зависимости от времени прошедшего с последнего ввода
                if (ScoreTime < 10)
                {
                    score += (100 * scoreMultiplier);
                    ScoreTime = 0;
                }
                else if (ScoreTime > 10 && ScoreTime < 35)
                {
                    score += (50 * scoreMultiplier);
                    ScoreTime = 0;
                }
                else if (ScoreTime > 35 && ScoreTime < 100)
                {
                    score += (20 * scoreMultiplier);
                    ScoreTime = 0;
                }
                else
                {
                    score += (10 * scoreMultiplier);
                    ScoreTime = 0;
                }
                UpdateScore(); //Обновление счета

                if (CheckEndGame()) //Проверяет завершена ли игра 
                {
                    //Сохраняет результат победы в файл соответствующий уровню сложности
                    if (FormMenu.easyGame)
                        readWriteWinResults.WriteWin(FormMenu.FileNameWinEasy);
                    else if (FormMenu.middleGame)
                        readWriteWinResults.WriteWin(FormMenu.FileNameWinMiddle);
                    else if (FormMenu.difficultGame)
                    {

                        readWriteWinResults.WriteWin(FormMenu.FileNameWinDifficult);
                    }

                    timer1.Stop();
                    timerScore.Stop();
                    DialogResult result = winForm.ShowDialog(); //Показывает форму победы

                    //Обрабатывает выбор игрока, возврат в меню или новая игра.
                    if (result == DialogResult.Cancel)
                    {
                        FormMenu.rule = new GameRule(FormMenu.ukrLang, FormMenu.light, FormMenu.easyGame, FormMenu.middleGame, FormMenu.difficultGame, FormMenu.limitMistakes, false);
                        Hide();
                    }
                    else if (result == DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Yes; //Сигнализирует о начале новой игры
                        FormMenu.rule = new GameRule(FormMenu.ukrLang, FormMenu.light, FormMenu.easyGame, FormMenu.middleGame, FormMenu.difficultGame, FormMenu.limitMistakes, false);
                        Hide();
                    }
                }
            }
            else
            {
                grid[selectedTextBoxI, selectedTextBoxJ].BackColor = Color.Red; //Подсветка красным
                countMistakes++; //Ошибка + 1
                UpdateCountMistakes(); //Обновление результата об ошибках

                if (FormMenu.limitMistakes && countMistakes == 3) //Если есть лимит ошибок и ошибок = 3
                {
                    timer1.Stop();
                    timerScore.Stop();
                    DialogResult result = looseForm.ShowDialog(); //Форма проигрыша

                    //Определение что делать в меню или новая игра
                    if (result == DialogResult.Cancel)
                    {
                        FormMenu.rule = new GameRule(FormMenu.ukrLang, FormMenu.light, FormMenu.easyGame, FormMenu.middleGame, FormMenu.difficultGame, FormMenu.limitMistakes, false);
                        Hide();
                    }
                    else if (result == DialogResult.Yes)
                    {
                        FormMenu.rule = new GameRule(FormMenu.ukrLang, FormMenu.light, FormMenu.easyGame, FormMenu.middleGame, FormMenu.difficultGame, FormMenu.limitMistakes, false);
                        DialogResult = DialogResult.Yes;
                        Hide();
                    }
                }
            }
        }

        private void SelectedIJ() //Значение i и j выделеного текст бокса
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    if (grid[i, j] == selectedTextBox)
                    {
                        selectedTextBoxI = i;
                        selectedTextBoxJ = j;
                        return;
                    }
                }
            }
        }

        private void UpdateCountMistakes() //Обновление данных об ошибках
        {
            labelCountMistakesInt.Text = FormMenu.limitMistakes ? $"{countMistakes} / 3" : Convert.ToString(countMistakes);
        }

        private void UpdateScore() //Обновление счета
        {
            labelScoreInt.Text = Convert.ToString(score);
        }

        private void TextBox_Click(object sender, EventArgs e) //Событиае клик по текст боксу
        {
            TextBox tb = (TextBox)sender; //Получает текстовое поле на которое нажал пользователь

            //Сброс цвета
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    if (grid[i, j].BackColor == Color.LightBlue)
                    {
                        grid[i, j].BackColor = grid[i, j].ReadOnly ? Color.FromArgb(240, 240, 240) : Color.White;
                    }
                }
            }

            selectedTextBox = tb; //Присваивание 
            SelectedIJ(); //Определение координат

            if (selectedTextBoxI > -1 && selectedTextBoxJ > -1)
            {
                // Устанавливаем голубой фон для строки
                for (int j = 0; j < n * n; j++)
                    if (grid[selectedTextBoxI, j] != tb && grid[selectedTextBoxI, j].BackColor != Color.Red)
                        grid[selectedTextBoxI, j].BackColor = Color.LightBlue;

                // Устанавливаем голубой фон для столбца
                for (int i = 0; i < n * n; i++)
                    if (grid[i, selectedTextBoxJ] != tb && grid[i, selectedTextBoxJ].BackColor != Color.Red)
                        grid[i, selectedTextBoxJ].BackColor = Color.LightBlue;

                // Устанавливаем голубой фон для блока 3x3
                int blockStartI = (selectedTextBoxI / n) * n;
                int blockStartJ = (selectedTextBoxJ / n) * n;

                for (int i = blockStartI; i < blockStartI + n; i++)
                    for (int j = blockStartJ; j < blockStartJ + n; j++)
                        if (grid[i, j] != tb && grid[i, j].BackColor != Color.Red)
                            grid[i, j].BackColor = Color.LightBlue;

                //Подсветка всех одиноковых значений
                for (int i = 0; i < n * n; i++)
                    for (int j = 0; j < n * n; j++)
                        if (grid[i, j] != tb && tb.Text == grid[i, j].Text && solutionBool[i, j])
                            grid[i, j].BackColor = Color.LightBlue;
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                TextBox textBox = (TextBox)sender;

                if (textBox.ReadOnly)
                {
                    e.Handled = true;
                    return;
                }

                selectedTextBox = textBox;
                int buttonIndex = e.KeyChar - '1'; // Получаем индекс кнопки (0–8)
                buttonNumber_Click(buttons[buttonIndex], EventArgs.Empty); // Вызываем клик кнопки
                e.Handled = true;
            }
            e.Handled = true;
        }

        private void pictureBoxLastik_Click(object sender, EventArgs e) //Нажатие на ластик
        {
            if (selectedTextBox == null || selectedTextBox.ReadOnly) //Если не выбрано или нельзя изменять то выход
            {
                return;
            }

            SelectedIJ();

            if (selectedTextBoxI > -1 && selectedTextBoxJ > -1)
            {
                grid[selectedTextBoxI, selectedTextBoxJ].Text = ""; //Сьрос текста
                grid[selectedTextBoxI, selectedTextBoxJ].BackColor = Color.White; //Установка белого цвета
            }
        }

        private void timerScore_Tick(object sender, EventArgs e) //Таймер для счета
        {
            ScoreTime++;
        }

        private void UpdateButtonVisibility(int number) //Скрытие кнопки если 9 на форме
        {
            int count = 0;
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    if (grid[i, j].Text == Convert.ToString(number) && solutionBool[i, j])
                    {
                        count++;
                    }
                }
            }

            if (count == 9)
            {
                buttons[number - 1].Visible = false;
            }
        }

        private bool CheckEndGame() //Проверка заполено все или нет
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    if (!solutionBool[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }


    }
}
