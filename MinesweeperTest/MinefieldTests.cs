using Minesweeper;

namespace MinesweeperTest
{
    public class MinefieldExplainerTests
    {
        [TestCase]
        public void IsMine_ReturnsTrue_WhenMinePresent()
        {
            char[,] minefield = new char[,]
            {
            { '_', '_', 'X' },
            { 'X', '_', '_' },
            { 'X', 'X', '_' }
            };

            bool result = MinefieldAnalyzer.IsMine(minefield, 0, 2);

            Assert.IsTrue(result);
        }

        [TestCase]
        public void IsMine_ReturnsFalse_WhenNoMinePresent()
        {
            char[,] minefield = new char[,]
            {
            { '_', 'X', 'X' },
            { 'X', 'X', '_' },
            { 'X', '_', '_' }
            };

            bool result = MinefieldAnalyzer.IsMine(minefield, 0, 0);

            Assert.IsFalse(result);
        }

        [TestCase]
        public void CountAdjacentMines_ReturnsCorrectCount()
        {
            char[,] minefield = new char[,]
            {
            { '_', 'X', 'X' },
            { 'X', 'X', '_' },
            { 'X', '_', '_' }
            };

            int count = MinefieldAnalyzer.CountAdjacentMines(minefield, 0, 1);

            Assert.AreEqual(4, count);
        }
    }
}