using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class MinefieldInitializer
    {
        public static char[,] InitializeMinefield(int size, int numMines)
        {
            char[,] minefield = new char[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    minefield[i, j] = '_';
                }
            }
            return PlaceMines(minefield, numMines);
        }

        public static char[,] PlaceMines(char[,] minefield, int numMines)
        {
            Random rand = new Random();
            int gridSize = minefield.GetLength(0);
            while (numMines > 0)
            {
                int row = rand.Next(0, gridSize);
                int col = rand.Next(0, gridSize);
                if (minefield[row, col] != 'X')
                {
                    minefield[row, col] = 'X';
                    numMines--;
                }
            }
            return minefield;
        }

    }
}
