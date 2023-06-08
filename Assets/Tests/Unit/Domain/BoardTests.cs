using NUnit.Framework;
using UCR.WorkshopTDD.Domain;

namespace UCR.WorkshopTDD.Tests.Unit.Domain
{
    [TestFixture]
    public class BoardTests
    {
        [Test]
        public void StartingAGame_HasA3X3_Board()
        {
            // Arrange
            var game = new Game();

            // Act
            game.Start();

            // Assert
            Assert.AreEqual(3, game.Board.Rows);
            Assert.AreEqual(3, game.Board.Columns);
        }

        [Test]
        public void StartingAGame_HasAnEmpty_Board()
        {
            // Arrange
            var game = new Game();

            // Act
            game.Start();

            // Assert
            Assert.IsTrue(game.Board.IsEmpty);
        }

        [Test]
        [TestCase(Symbol.X, 1, 2)]
        [TestCase(Symbol.O, 1, 2)]
        [TestCase(Symbol.X, 3, 2)]
        [TestCase(Symbol.O, 3, 3)]
        public void SettingASymbolOnBoard_PersistsTheSymbol(Symbol symbol, int row, int column)
        {
            // Arrange
            var board = new Board(Game.Rows, Game.Columns);

            // Act
            board.SetSymbol(symbol, row, column);

            // Assert
            Assert.AreEqual(symbol , board.GetSymbol(row, column));
        }
    }
}
