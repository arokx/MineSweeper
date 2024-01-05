using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class InputManager
    {
        static public int GetGridSize()
        {
            int size;
            do
            {
                Console.Write("Enter the size of the grid (2 to 10): ");
            } while (!int.TryParse(Console.ReadLine(), out size) || size < 2 || size > 10);

            return size;
        }

        static public int GetNumberOfMines(int maxMines)
        {
            int numMines;
            do
            {
                Console.Write($"Enter the number of mines (1 to {maxMines}): ");
            } while (!int.TryParse(Console.ReadLine(), out numMines) || numMines < 1 || numMines > maxMines);

            return numMines;
        }

        public static string GetUserInput(int gridSize)
        {
            string input;
            do
            {
                Console.Write("Select a square to reveal (e.g. A1): ");
                input = Console.ReadLine().ToUpper();
            } while (input.Length < 2 || input.Length > 3 || input[0] < 'A' || input[0] >= 'A' + gridSize ||
                     !int.TryParse(input.Substring(1), out int col) || col < 1 || col > gridSize);

            return input;
        }
    }
}
