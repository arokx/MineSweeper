
using Minesweeper;

class Program
{
  static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Minesweeper!\n");

        var game = new MinesweeperGame();
        game.Play();

        Console.WriteLine("Press any key to play again...");
        Console.ReadKey();
    }
}
