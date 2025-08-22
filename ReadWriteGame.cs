using System;
using System.IO;

namespace Gunchenko_Sudoku
{
    public class ReadWriteGame //Класс для записи и чтения файла
    {
        public void Read(string fileInfo) //Чтение файла
        {
            StreamReader sr = new StreamReader(fileInfo);
            for (int i = 0; i < 9; i++)
            {
                string line = sr.ReadLine();
                string[] numbers = line.Split(' ');

                for (int j = 0; j < 9; j++)
                {
                    Game.solution[i, j] = Convert.ToInt32(numbers[j]); //Чтение решения
                }
            }
            sr.Close();
        }

        public void Write(string fileInfo) //Перезапись файла
        {
            StreamWriter sw = new StreamWriter(fileInfo, false); // false - перезаписывать файл
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sw.Write(Game.solution[i, j] + " "); //Перезаписывает решение
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        public void WriteResults(string fileInfo) //Запись результатов
        {
            StreamWriter writer = new StreamWriter(fileInfo, false);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    writer.Write(Game.solutionBool[i, j] + " "); //Перезапись что откурто что закрыто
                }
                writer.WriteLine();
            }

            writer.Write(Game.seconds + " " + Game.countMistakes + " " + Game.ScoreTime + " " + Game.score); //Запись всех значений
            writer.Close();
        }

        public void ReadResults(string fileInfo) //Чтение файла результата
        {
            StreamReader reader = new StreamReader(fileInfo, false);
            for (int i = 0; i < 9; i++)
            {
                string line = reader.ReadLine();
                string[] booleans = line.Split(' ');

                for (int j = 0; j < 9; j++)
                {
                    Game.solutionBool[i, j] = Convert.ToBoolean(booleans[j]); //Чтение что открыто что закрыто
                }
            }
            string lineCount = reader.ReadLine();
            string[] counts = lineCount.Split(' ');
            Game.seconds = Convert.ToInt32(counts[0]); //Инициализация секунд
            Game.countMistakes = Convert.ToInt32(counts[1]);
            Game.ScoreTime = Convert.ToInt32(counts[2]);
            Game.score = Convert.ToInt32(counts[3]);
            reader.Close();
        }

    }
}
