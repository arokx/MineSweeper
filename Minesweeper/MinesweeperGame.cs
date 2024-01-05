using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class MinesweeperGame
    {
        private int gridSize;
        private int numMines;
        private int maxMines;
        private char[,] minefield;
        private bool[,] revealed;

        public MinesweeperGame()
        {
            gridSize = InputManager.GetGridSize();
            maxMines = (int)(gridSize * gridSize * 0.35);
            numMines = InputManager.GetNumberOfMines(maxMines);
            minefield = MinefieldInitializer.InitializeMinefield(gridSize, numMines);
            revealed = new bool[gridSize, gridSize];
        }

        public void Play()
        {
            bool gameOver = false;

            while (!gameOver)
            {
                MinefieldPrinter.Print(minefield, revealed);
                string input = InputManager.GetUserInput(gridSize);
                int row = input[0] - 'A';
                int col = int.Parse(input.Substring(1)) - 1;

                if (MinefieldAnalyzer.IsMine(minefield, row, col))
                {
                    Console.WriteLine("Oh no, you detonated a mine! Game over.");
                    gameOver = true;
                }
                else
                {
                    int adjacentMines = MinefieldAnalyzer.CountAdjacentMines(minefield, row, col);
                    revealed[row, col] = true;
                    minefield[row, col] = (char)(adjacentMines + '0');

                    if (adjacentMines == 0)
                    {
                        MinefieldAnalyzer.UncoverAdjacentSquares(minefield, revealed, row, col);
                    }

                    if (MinefieldAnalyzer.CheckWinCondition(minefield, revealed, numMines))
                    {
                        Console.WriteLine("Congratulations, you have won the game!");
                        gameOver = true;
                    }
                }
            }
        }
    }
}

