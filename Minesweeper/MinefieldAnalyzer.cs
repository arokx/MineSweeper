using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class MinefieldAnalyzer
    {
        public static bool IsMine(char[,] minefield, int row, int col)
        {
            return minefield[row, col] == 'X';
        }

        public static int CountAdjacentMines(char[,] minefield, int row, int col)
        {
            int count = 0;
            int gridSize = minefield.GetLength(0);

            for (int r = Math.Max(0, row - 1); r <= Math.Min(gridSize - 1, row + 1); r++)
            {
                for (int c = Math.Max(0, col - 1); c <= Math.Min(gridSize - 1, col + 1); c++)
                {
                    if (minefield[r, c] == 'X')
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static void UncoverAdjacentSquares(char[,] minefield, bool[,] revealed, int row, int col)
        {
            int gridSize = minefield.GetLength(0);

            for (int r = Math.Max(0, row - 1); r <= Math.Min(gridSize - 1, row + 1); r++)
            {
                for (int c = Math.Max(0, col - 1); c <= Math.Min(gridSize - 1, col + 1); c++)
                {
                    if (!revealed[r, c])
                    {
                        revealed[r, c] = true;
                        int adjacentMines = CountAdjacentMines(minefield, r, c);
                        minefield[r, c] = (char)(adjacentMines + '0');
                        if (adjacentMines == 0)
                        {
                            UncoverAdjacentSquares(minefield, revealed, r, c);
                        }
                    }
                }
            }
        }

        public static bool CheckWinCondition(char[,] minefield, bool[,] revealed, int numMines)
        {
            int gridSize = minefield.GetLength(0);
            int numRevealed = 0;
            for (int r = 0; r < gridSize; r++)
            {
                for (int c = 0; c < gridSize; c++)
                {
                    if (revealed[r, c])
                    {
                        numRevealed++;
                    }
                }
            }
            return numRevealed == (gridSize * gridSize) - numMines;
        }
    }
}
