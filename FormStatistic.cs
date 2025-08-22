using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gunchenko_Sudoku
{
    public partial class FormStatistic : Form //Форма статистики
    {
        ReadWriteWinResults readWriteWinResults = new ReadWriteWinResults(); //Экземпляр класса для чтение файлов про результаты игры

        int standartTextBoxes = 3; //Колечество по умолчанию

        int countEasyLines; //Переменный количества строк в фалах
        int countMidleLines;
        int countDifficultLines;

        static public int[,] easyCounts; //Масив для записи значений с файлов
        static public int[,] middeCounts;
        static public int[,] difficultCounts;

        TextBox[,] easyTextBoxes; //Текст боксы для показа результатов игр
        TextBox[,] middleTextBoxes;
        TextBox[,] difficultTextBoxes;

        private void SetCounts() //Метод для инициализации переменных количества строк в файле
        {
            countEasyLines = readWriteWinResults.ReadCount(FormMenu.FileNameWinEasy);
            countMidleLines = readWriteWinResults.ReadCount(FormMenu.FileNameWinMiddle);
            countDifficultLines = readWriteWinResults.ReadCount(FormMenu.FileNameWinDifficult);
        }

        private void SetEasyBoxes() //Метод установки текст боксов для результатов простых игр
        {
            readWriteWinResults.ReadWin(FormMenu.FileNameWinEasy, true, false, false); //Чтение результатов прошлых простых игр, передается имя файла и то что легкая игра

            SetCounts(); //Вызов метода инициализации переменных

            int count; //Объявление переменной количества текст боков
            if (standartTextBoxes < countEasyLines) //Если в файле меньше 3 строк, то будет 3 строки текст боксов
                 count = countEasyLines;
            else count = standartTextBoxes;

            easyTextBoxes = new TextBox[count, 3]; //Инициализация массива текст бокса, количестро строк и столбцов

            int writeAll = 0; //Переменная для записи данных

            int yPosition = 4;  //Начальная координата у
            for (int i = 0; i < count; i++)
            {
                int xPosition = 3; //Начальная позиция х
                for (int j = 0; j < 3; j++)
                {
                    easyTextBoxes[i, j] = new TextBox(); //Инициализация текст бокса
                    easyTextBoxes[i, j].Size = new Size(90, 25); //Установка размера
                    easyTextBoxes[i, j].Location = new Point(xPosition, yPosition); //Координаты
                    easyTextBoxes[i, j].Font = new Font("Trebuchet MS", 10f); //Шрифт и его размер
                    easyTextBoxes[i, j].ReadOnly = true; //Только для чтения, нельзя изменять содержимое
                    easyTextBoxes[i, j].TextAlign = HorizontalAlignment.Center; //Текст будет по середине
                    if (!(writeAll >= countEasyLines)) //Если записано не больше чем есть в файле
                    {
                        if (j == 0) // Для столбца времени
                            easyTextBoxes[i, j].Text = TimeSpan.FromSeconds(easyCounts[i, j]).ToString(@"mm\:ss"); //В виде минуты:секунды
                        else
                            easyTextBoxes[i, j].Text = Convert.ToString(easyCounts[i, j]);
                    }
                    else
                        easyTextBoxes[i, j].Text = ""; //Пустая строка

                    panelEasy.Controls.Add(easyTextBoxes[i, j]); //Добавление кнопки на панель
                    xPosition += 95; //Изменение позиции х
                }                    
                writeAll++; //Количество записанных строк

                yPosition += 35;  //Изменение позиции х
            }
        }

        private void SetMiddleBoxes() //Метод установки текст боксов для средней сложности игры
        {
            readWriteWinResults.ReadWin(FormMenu.FileNameWinMiddle, false, true, false);

            SetCounts();

            int count;
            if (standartTextBoxes < countMidleLines)
                count = countMidleLines;
            else count = standartTextBoxes;

            middleTextBoxes = new TextBox[count, 3];

            int writeAll = 0;

            int yPosition = 4;
            for (int i = 0; i < count; i++)
            {
                int xPosition = 3;
                for (int j = 0; j < 3; j++)
                {
                    middleTextBoxes[i, j] = new TextBox();
                    middleTextBoxes[i, j].Size = new Size(90, 25);
                    middleTextBoxes[i, j].Location = new Point(xPosition, yPosition);
                    middleTextBoxes[i, j].Font = new Font("Trebuchet MS", 10f);
                    middleTextBoxes[i, j].ReadOnly = true;
                    middleTextBoxes[i, j].TextAlign = HorizontalAlignment.Center;
                    if (!(writeAll >= countMidleLines)) 
                    {
                        if (j == 0) 
                            middleTextBoxes[i, j].Text = TimeSpan.FromSeconds(middeCounts[i, j]).ToString(@"mm\:ss"); //В виде минуты:секунды
                        else
                            middleTextBoxes[i, j].Text = Convert.ToString(middeCounts[i, j]);
                    }
                    else
                        middleTextBoxes[i, j].Text = "";

                    panelMiddle.Controls.Add(middleTextBoxes[i, j]);
                    xPosition += 95;
                }
                writeAll++;

                yPosition += 35;
            }
        }

        private void SetDifficultBoxes() //Метод установки текст боксов для сложной сложности игры
        {
            readWriteWinResults.ReadWin(FormMenu.FileNameWinDifficult, false, false, true);

            SetCounts();

            int count;
            if (standartTextBoxes < countDifficultLines)
                count = countDifficultLines;
            else count = standartTextBoxes;

            difficultTextBoxes = new TextBox[count, 3];

            int writeAll = 0;

            int yPosition = 4;
            for (int i = 0; i < count; i++)
            {
                int xPosition = 3;
                for (int j = 0; j < 3; j++)
                {
                    difficultTextBoxes[i, j] = new TextBox();
                    difficultTextBoxes[i, j].Size = new Size(90, 25);
                    difficultTextBoxes[i, j].Location = new Point(xPosition, yPosition);
                    difficultTextBoxes[i, j].Font = new Font("Trebuchet MS", 10f);
                    difficultTextBoxes[i, j].ReadOnly = true;
                    difficultTextBoxes[i, j].TextAlign = HorizontalAlignment.Center;
                    if (!(writeAll >= countDifficultLines))
                    {
                        if (j == 0)
                            difficultTextBoxes[i, j].Text = TimeSpan.FromSeconds(difficultCounts[i, j]).ToString(@"mm\:ss"); //В виде минуты:секунды
                        else
                            difficultTextBoxes[i, j].Text = Convert.ToString(difficultCounts[i, j]);
                    }
                    else
                        difficultTextBoxes[i, j].Text = "";

                    panelDifficult.Controls.Add(difficultTextBoxes[i, j]);
                    xPosition += 95;
                }
                writeAll++;

                yPosition += 35;
            }
        }

        private void ChangeTopic() //Метод для изменение цвета формы
        {
            BackColor = FormMenu.light ? Color.FromArgb(230, 240, 255) : Color.FromArgb(50, 50, 80);
            labelStatistic.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelStatisticEasy.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelStatisticMiddl.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelStatisticDifficult.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);

            labelTime1.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelTime2.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelTime3.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelMistakes1.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelMistakes2.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelMistakes3.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelScore1.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelScore2.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);
            labelScore3.ForeColor = FormMenu.light ? Color.FromArgb(50, 50, 100) : Color.FromArgb(200, 200, 255);

            returnButton.BackColor = FormMenu.light ? Color.FromArgb(180, 220, 255) : Color.FromArgb(100, 100, 150);
        }

        private void ChangeLanguage() //Метод для изменения языка формы
        {
            labelStatisticMiddl.Text = FormMenu.ukrLang ? "Середній" : "Средний";
            labelStatisticDifficult.Text = FormMenu.ukrLang ? "Складний" : "Сложный";

            labelTime1.Text = FormMenu.ukrLang ? "Час" : "Время";
            labelTime2.Text = FormMenu.ukrLang ? "Час" : "Время";
            labelTime3.Text = FormMenu.ukrLang ? "Час" : "Время";
            labelMistakes1.Text = FormMenu.ukrLang ? "Помилок" : "Ошибок";
            labelMistakes2.Text = FormMenu.ukrLang ? "Помилок" : "Ошибок";
            labelMistakes3.Text = FormMenu.ukrLang ? "Помилок" : "Ошибок";
            labelScore1.Text = FormMenu.ukrLang ? "Рахунок" : "Счёт";
            labelScore2.Text = FormMenu.ukrLang ? "Рахунок" : "Счёт";
            labelScore3.Text = FormMenu.ukrLang ? "Рахунок" : "Счёт";
        }

        public FormStatistic()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e) //Собите клик для выхода с формы
        {
            Close();
        }

        private void FormStatistic_Load(object sender, EventArgs e) //Событие загрузки формы
        {
            ChangeTopic(); //Установка цвета формы
            
            ChangeLanguage(); //Установка языка

            UpdateAllBoxes(); //Переустановка текстбоксов 

        }

        private void UpdateAllBoxes() //Метод перестановки текст боксов
        {
            panelEasy.Controls.Clear(); //Очистка панелей для обновления данных
            panelMiddle.Controls.Clear();
            panelDifficult.Controls.Clear();

            SetEasyBoxes(); //Вызов методов для установки текст боксов
            SetMiddleBoxes();
            SetDifficultBoxes();
        }
    }
}
