using System;
using System.IO;

namespace Gunchenko_Sudoku
{
    public class ReadWriteWinResults
    {
        public void WriteWin(string nameFile)
        {
            FileInfo fileInfo = new FileInfo(nameFile);
            if (!fileInfo.Exists)
            {
                fileInfo.Create().Close();
            }

            StreamWriter sw = new StreamWriter(fileInfo.FullName, true); 
            sw.WriteLine(Game.seconds + " " + Game.countMistakes + " " + Game.score);
            sw.Close();
        }

        public void ReadWin(string nameFile, bool easy, bool middle, bool difficult)
        {
            int count = ReadCount(nameFile);
            if (easy)
                FormStatistic.easyCounts = new int[count, 3];
            else if (middle)
                FormStatistic.middeCounts = new int[count, 3];
            else if (difficult)
                FormStatistic.difficultCounts = new int[count, 3];

            FileInfo fileInfo = new FileInfo(nameFile);

            StreamReader sr = new StreamReader(fileInfo.FullName);

            for (int i = 0; i < count; i++)
            {
                string line = sr.ReadLine();
                string[] counts = line.Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    if (easy)
                    {
                        FormStatistic.easyCounts[i, j] = Convert.ToInt32(counts[j]);
                    }
                    else if (middle)
                    {
                        FormStatistic.middeCounts[i, j] = Convert.ToInt32(counts[j]);

                    }
                    else if (difficult)
                    {
                        FormStatistic.difficultCounts[i, j] = Convert.ToInt32(counts[j]);

                    }
                }
            }
            sr.Close();
        }

        public int ReadCount(string nameFile)
        {
            FileInfo fileInfo = new FileInfo(nameFile);
            if (!fileInfo.Exists)
            {
                fileInfo.Create().Close();
            }

            StreamReader sr = new StreamReader(fileInfo.FullName);

            string line;
            int count = 0;  
            while ((line = sr.ReadLine()) != null)
            {
                count++;
            }
            sr.Close();
            return count;
        }
    }
}
