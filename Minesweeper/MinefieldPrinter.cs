using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class MinefieldPrinter
    {
        public static void Print(char[,] minefield, bool[,] revealed)
        {
            int gridSize = minefield.GetLength(0);

            Console.WriteLine("\nHere is your minefield:");
            Console.Write("  ");
            for (int col = 0; col < gridSize; col++)
            {
                Console.Write($"{col + 1} ");
            }
            Console.WriteLine();

            for (int row = 0; row < gridSize; row++)
            {
                Console.Write((char)('A' + row) + " ");
                for (int col = 0; col < gridSize; col++)
                {
                    if (revealed[row, col])
                    {
                        Console.Write(minefield[row, col] + " ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
