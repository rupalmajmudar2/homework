using NUnit.Framework;
using NUnit.Framework.Internal;

using RmHomeworkProject.problems;

public class ChessKnightAllSquaresTest 
{
    [Test]
    public void Test() {
        ChessKnightAllSquares board = new ChessKnightAllSquares();
        board.Intialize();
        string position = board.GetBoardPosition();

        string prn = "";
        prn = board.Start(0,0, 0, prn);

        prn = board.Continue(prn);

        string endPosition = board.GetBoardPosition();

        Assert.IsTrue(board.IsFull());


    }
}
