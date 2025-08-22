using System;

namespace Gunchenko_Sudoku
{
    public class GenerationGame
    {
        Random random = new Random();
        ReadWriteGame readWriteGame = new ReadWriteGame();

        public void GenerateStandartGame()
        {
            ClearGame();
            for (int i = 0; i < Game.n * Game.n; i++)
            {
                for (int j = 0; j < Game.n * Game.n; j++)
                {
                    Game.solution[i, j] = (i * Game.n + i / Game.n + j) % (Game.n * Game.n) + 1;
                }
            }
        }

        public void Transposition()
        {
            int[,] temp = new int[Game.n * Game.n, Game.n * Game.n];
            for (int i = 0; i < Game.n * Game.n; i++)
            {
                for (int j = 0; j < Game.n * Game.n; j++)
                {
                    temp[i, j] = Game.solution[j, i];
                }
            }
            Game.solution = temp;
        }

        public void SwapRowsInBlock()
        {
            int block = random.Next(0, Game.n);
            int row1 = random.Next(0, Game.n);
            int line1 = block * Game.n + row1;
            int row2 = random.Next(0, Game.n);
            while (row1 == row2)
                row2 = random.Next(0, Game.n);
            int line2 = block * Game.n + row2;
            for (int i = 0; i < Game.n * Game.n; i++)
            {
                int temp = Game.solution[line1, i];
                Game.solution[line1, i] = Game.solution[line2, i];
                Game.solution[line2, i] = temp;
            }
        }

        public void SwapColumnsInBlock()
        {
            int block = random.Next(0, Game.n);
            int row1 = random.Next(0, Game.n);
            int line1 = block * Game.n + row1;
            int row2 = random.Next(0, Game.n);
            while (row1 == row2)
                row2 = random.Next(0, Game.n);
            int line2 = block * Game.n + row2;
            for (int i = 0; i < Game.n * Game.n; i++)
            {
                int temp = Game.solution[i, line1];
                Game.solution[i, line1] = Game.solution[i, line2];
                Game.solution[i, line2] = temp;
            }
        }

        public void SwapBlocksInRow()
        {
            int block1 = random.Next(0, Game.n);
            int block2 = random.Next(0, Game.n);
            while (block1 == block2)
                block2 = random.Next(0, Game.n);
            block1 *= Game.n;
            block2 *= Game.n;
            for (int i = 0; i < Game.n * Game.n; i++)
            {
                int k = block2;
                for (int j = block1; j < block1 + Game.n; j++)
                {
                    int temp = Game.solution[j, i];
                    Game.solution[j, i] = Game.solution[k, i];
                    Game.solution[k, i] = temp;
                    k++;
                }
            }
        }

        public void SwapBlocksInColumn()
        {
            int block1 = random.Next(0, Game.n);
            int block2 = random.Next(0, Game.n);
            while (block1 == block2)
                block2 = random.Next(0, Game.n);
            block1 *= Game.n;
            block2 *= Game.n;
            for (int i = 0; i < Game.n * Game.n; i++)
            {
                int k = block2;
                for (int j = block1; j < block1 + Game.n; j++)
                {
                    int temp = Game.solution[i, j];
                    Game.solution[i, j] = Game.solution[i, k];
                    Game.solution[i, k] = temp;
                    k++;
                }
            }
        }

        public void ClearGame()
        {
            for (int i = 0; i < Game.n * Game.n; i++)
            {
                for (int j = 0; j < Game.n * Game.n; j++)
                {
                    Game.solution[i, j] = 0;
                }
            }
        }

        public void GenerateGame()
        {
            RandomMap();
            int count = random.Next(20, 50);
            for (int i = 0; i < count; i++)
            {
                int r = random.Next(0, 5);
                switch (r)
                {
                    case 0:
                        Transposition();
                        break;
                    case 1:
                        SwapRowsInBlock();
                        break;
                    case 2:
                        SwapColumnsInBlock();
                        break;
                    case 3:
                        SwapBlocksInRow();
                        break;
                    case 4:
                        SwapBlocksInColumn();
                        break;
                }
            }
            readWriteGame.Write(Game.WriteFilePath);
        }

        public void RandomMap()
        {
            int randomGame = random.Next(1, Game.countMaps + 1);
            try
            {
                if (randomGame == 1) GenerateStandartGame();
                else
                {
                    string filePath = Game.ReadFilePath + $"{randomGame}.txt";
                    readWriteGame.Read(filePath);
                }
            }
            catch
            {
                RandomMap();
            }
        }

        public void HideTexts()
        {
            for (int i = 0; i < Game.n * Game.n; i++)
            {
                for (int j = 0; j < Game.n * Game.n; j++)
                {
                    Game.solutionBool[i, j] = true;
                }
            }

            if (FormMenu.easyGame) Game.HideTextBoxes = random.Next(38, 45);
            else if (FormMenu.middleGame) Game.HideTextBoxes = random.Next(45, 53);
            else Game.HideTextBoxes = random.Next(53, 60);

            int hidden = 0;
            while (hidden < Game.HideTextBoxes)
            {
                int i = random.Next(0, Game.n * Game.n);
                int j = random.Next(0, Game.n * Game.n);
                if (Game.grid[i, j].Text != "")
                {
                    Game.grid[i, j].Text = "";
                    Game.solutionBool[i, j] = false;
                    hidden++;
                }
            }
        }

    }
}
