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
            // Assert.AreEqual(Symbol.Empty, game.Board.GetSymbol(0, 0));
            // Assert.AreEqual(Symbol.Empty, game.Board.GetSymbol(0, 1));
            // Assert.AreEqual(Symbol.Empty, game.Board.GetSymbol(0, 2));
            // Assert.AreEqual(Symbol.Empty, game.Board.GetSymbol(1, 0));
            // Assert.AreEqual(Symbol.Empty, game.Board.GetSymbol(1, 1));
            // Assert.AreEqual(Symbol.Empty, game.Board.GetSymbol(1, 2));
            // Assert.AreEqual(Symbol.Empty, game.Board.GetSymbol(2, 0));
            // Assert.AreEqual(Symbol.Empty, game.Board.GetSymbol(2, 1));
            // Assert.AreEqual(Symbol.Empty, game.Board.GetSymbol(2, 2));
        }
    }
}
