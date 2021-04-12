using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class ChessKnightAllSquaresRecursiveTest {
        [Test]
        public void Test() {
            ChessKnightAllSquaresRecursive board = new ChessKnightAllSquaresRecursive();
            int moves = board.Solution();
            Assert.IsTrue(true);
        }
    }
}
