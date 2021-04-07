using Application.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TicTacToe.Tests
{
    [TestClass]
    public class TicTacToeTests
    {
        [TestMethod]
        public void TicTacToe_PlaceFirstRow_Winning()
        {
            int boardSize = 5;
            var ticTacToe = new Application.Model.TicTacToe(boardSize)
            {
                Player1 = new Client { ConnectionId = Guid.NewGuid().ToString(), BoardSize = boardSize },
                Player2 = new Client { ConnectionId = Guid.NewGuid().ToString(), BoardSize = boardSize }
            };

            ticTacToe.Play(0, 0);
            ticTacToe.Play(1, 24);
            ticTacToe.Play(0, 1);
            ticTacToe.Play(1, 7);
            ticTacToe.Play(0, 2);
            ticTacToe.Play(1, 9);
            ticTacToe.Play(0, 3);
            ticTacToe.Play(1, 10);
            ticTacToe.Play(0, 4);

            Assert.IsTrue(ticTacToe.IsGameOver);
        }

        [TestMethod]
        public void TicTacToe_PlaceSecondRow_Winning()
        {
            int boardSize = 3;
            var ticTacToe = new Application.Model.TicTacToe(boardSize)
            {
                Player1 = new Client { ConnectionId = Guid.NewGuid().ToString(), BoardSize = boardSize },
                Player2 = new Client { ConnectionId = Guid.NewGuid().ToString(), BoardSize = boardSize }
            };

            ticTacToe.Play(0, 0);
            ticTacToe.Play(1, 3);
            ticTacToe.Play(0, 1);
            ticTacToe.Play(1, 4);
            ticTacToe.Play(0, 6);
            ticTacToe.Play(1, 5);

            Assert.IsTrue(ticTacToe.IsGameOver);
        }

        [TestMethod]
        public void TicTacToe_PlaceThirdRow_Winning()
        {
            int boardSize = 4;
            var ticTacToe = new Application.Model.TicTacToe(boardSize)
            {
                Player1 = new Client { ConnectionId = Guid.NewGuid().ToString(), BoardSize = boardSize },
                Player2 = new Client { ConnectionId = Guid.NewGuid().ToString(), BoardSize = boardSize }
            };

            ticTacToe.Play(0, 8);
            ticTacToe.Play(1, 6);
            ticTacToe.Play(0, 9);
            ticTacToe.Play(1, 7);
            ticTacToe.Play(0, 10);
            ticTacToe.Play(1, 3);
            ticTacToe.Play(0, 11);

            Assert.IsTrue(ticTacToe.IsGameOver);
        }

        [TestMethod]
        public void TicTacToe_PlaceDiagonalOne_Winning()
        {
            int boardSize = 6;
            var ticTacToe = new Application.Model.TicTacToe(boardSize)
            {
                Player1 = new Client { ConnectionId = Guid.NewGuid().ToString(), BoardSize = boardSize },
                Player2 = new Client { ConnectionId = Guid.NewGuid().ToString(), BoardSize = boardSize }
            };

            ticTacToe.Play(0, 5);
            ticTacToe.Play(1, 3);
            ticTacToe.Play(0, 10);
            ticTacToe.Play(1, 7);
            ticTacToe.Play(0, 15);
            ticTacToe.Play(1, 9);
            ticTacToe.Play(0, 20);
            ticTacToe.Play(1, 13);
            ticTacToe.Play(0, 25);
            ticTacToe.Play(1, 16);
            ticTacToe.Play(0, 30);

            Assert.IsTrue(ticTacToe.IsGameOver);
        }

        [TestMethod]
        public void TicTacToe_PlaceDiagonalTwo_Winning()
        {
            int boardSize = 5;
            var ticTacToe = new Application.Model.TicTacToe(boardSize)
            {
                Player1 = new Client { ConnectionId = Guid.NewGuid().ToString(), BoardSize = boardSize },
                Player2 = new Client { ConnectionId = Guid.NewGuid().ToString(), BoardSize = boardSize }
            };

            ticTacToe.Play(0, 0);
            ticTacToe.Play(1, 1);
            ticTacToe.Play(0, 6);
            ticTacToe.Play(1, 7);
            ticTacToe.Play(0, 12);
            ticTacToe.Play(1, 8);
            ticTacToe.Play(0, 18);
            ticTacToe.Play(1, 19);
            ticTacToe.Play(0, 24);

            Assert.IsTrue(ticTacToe.IsGameOver);
        }
    }
}
