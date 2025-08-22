using System;
using System.Collections.Generic;
using System.IO;

namespace Gunchenko_Sudoku
{
    public class GameRule
    {
        bool ukraineLang;

        bool lightTopic;

        bool easyGame;
        bool middleGame;
        bool dificcultGame;

        bool limitMistakes;

        bool continueGame;


        List<string> rules;

        public GameRule(bool ukraineLang, bool lightTopic, bool easyGame, bool middleGame, bool dificcultGame, bool limitMistakes, bool continueGame)
        {
            this.ukraineLang = ukraineLang;

            this.lightTopic = lightTopic;
            
            this.easyGame = easyGame;
            this.middleGame = middleGame;
            this.dificcultGame = dificcultGame;
            
            this.limitMistakes = limitMistakes;

            this.continueGame = continueGame;

            SaveToFile();
        }

        public GameRule() { ukraineLang = true; lightTopic = true; 
            easyGame = true; middleGame = false; dificcultGame = false;
            limitMistakes = false; continueGame = false;

            SaveToFile();
        }

        public List<string> InformFile()
        {
            rules = new List<string>();

            rules.Add("Украинский да/нет" + "\t" + "Светлая тема да/нет" +
                "\t" + "Легкая игра" + "\t" + "Средняя игра" + "\t" + "Тяжелая игра" +
                "\t" + "Лимит ошибок" + "\t" + "Продолжить игру да/нет" + "\n");
            rules.Add(Convert.ToString(ukraineLang) + "\t" + 
                Convert.ToString(lightTopic) + "\t" + 
                Convert.ToString(easyGame) + "\t" + 
                Convert.ToString(middleGame) + "\t" + 
                Convert.ToString(dificcultGame) + "\t" + 
                Convert.ToString(limitMistakes) + "\t" +
                Convert.ToString(continueGame));
            return rules;
        }

        public void SaveToFile()
        {
            FileInfo fileInfo = new FileInfo(FormMenu.FileName);
            if (!fileInfo.Exists) fileInfo.Create().Close();

            StreamWriter streamWriter = new StreamWriter(FormMenu.FileName, false);

            foreach (string str in InformFile())
            {
                streamWriter.Write(str);
            }
            streamWriter.Close();
        }

        static public void ReadBoolFile()
        {
            FileInfo fileInfo = new FileInfo(FormMenu.FileName);
            if (!fileInfo.Exists)
            {
                fileInfo.Create().Close();
                GameRule rule = new GameRule();
            }

            StreamReader sr = new StreamReader(fileInfo.FullName);
            sr.ReadLine();
            string line = sr.ReadLine();
            string[] rules = line.Split('\t');
            FormMenu.ukrLang = Convert.ToBoolean(rules[0]);
            FormMenu.light = Convert.ToBoolean(rules[1]);
            FormMenu.easyGame = Convert.ToBoolean(rules[2]);
            FormMenu.middleGame = Convert.ToBoolean(rules[3]);
            FormMenu.difficultGame = Convert.ToBoolean(rules[4]);
            FormMenu.limitMistakes = Convert.ToBoolean(rules[5]);
            FormMenu.continueGame = Convert.ToBoolean(rules[6]);
            sr.Close();
        }

    }
}
