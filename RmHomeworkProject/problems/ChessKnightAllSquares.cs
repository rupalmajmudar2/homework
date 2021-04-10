using NUnit.Framework;
using NUnit.Framework.Internal;

namespace RmHomeworkProject.problems {
    public class ChessKnightAllSquares {
        private int[,] Squares = new int[8, 8];

        public void Intialize() {
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    Squares[i, j] = -1;
                }
            }
        }

        public string Start(int i, int j, int level, string prn) {
            prn += " Starting at [" + i + "," + j + "] : ";
            prn = ExecuteFrom(i, j, level, prn);
            prn = ExecuteFrom(i + 2, j + 1, level, prn);
            prn = ExecuteFrom(i + 2, j - 1, level, prn);
            prn = ExecuteFrom(i + 1, j + 2, level, prn);
            prn = ExecuteFrom(i + 1, j - 2, level, prn);
            prn = ExecuteFrom(i - 2, j + 1, level, prn);
            prn = ExecuteFrom(i - 2, j - 1, level, prn);
            prn = ExecuteFrom(i - 1, j + 2, level, prn);
            prn = ExecuteFrom(i - 1, j - 2, level, prn);

            return prn;
        }

        public string Continue(string prn) {
            for (int level = 0; level < 5; level++) {
                for (int i = 0; i < 8; i++) {
                    for (int j = 0; j < 8; j++) {
                        if (Squares[i, j] == level) {
                            prn = Start(i, j, (level + 1), prn);
                        }
                    }
                }
            }

            return prn;
        }

        public string ContinueUntil(int finalX, int finalY, string prn) {
            for (int level = 0; level < 5; level++) {
                for (int i = 0; i < 8; i++) {
                    for (int j = 0; j < 8; j++) {
                        if (Squares[i, j] == level) {
                            prn = Start(i, j, (level + 1), prn);
                            if (Squares[finalX,finalY] != -1) {
                                prn += " DONE! Level = " + level;
                                return prn;
                            }
                        }
                    }
                }
            }

            return prn;
        }


        public bool IsFull() {
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if (Squares[i, j] == -1) {
                        return false;
                    }
                }
            }

            return true;
        }

        public string ExecuteFrom(int i, int j, int level, string prn) {
            if ((i >= 0) && (i < 8) && (j >= 0) && (j < 8)) {
                prn = Execute(i, j, level, prn);
            }

            return prn;
        }

        public string Execute(int i, int j, int level, string prn) {
            if (Squares[i, j] == -1) { //unfilled
                Squares[i, j] = level;
                prn += "[" + i + "," + j + "] = " + level + ". ";
            }

            return prn;
        }

        public string GetBoardPosition() {
            string result = "";
            for (int i = 0; i < 8; i++) {
                result += "\n Row#" + i + " : ";
                for (int j = 0; j < 8; j++) {
                    result += Squares[i, j] + " ";
                }
            }

            return result;
        }
    }
}
