using System;

namespace RmHomeworkProject.problems {
    class ChessKnightAllSquaresRecursive {
        static int N = 100; //Board size
        static int StartX = 0;
        static int StartY = 0;
        private int[,] Squares = new int[N, N];

        public int Solution() {
            Intialize();
            Solve();
            return 0;
        }

        public void Intialize() {
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    Squares[i, j] = -1;
                }
            }
        }

        public bool Solve() {
            int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };

            // Start at the first block
            Squares[StartX, StartY] = 0;

            /* Solve recursively */
            if (!SolveRecursively(StartX, StartX, 1, xMove, yMove)) {
                Console.WriteLine("Solution does not exist");
                return false;
            }
            else
                PrintSolution();

            return true;
        }

        private bool SolveRecursively(int x, int y, int moveNr, int[] xMove, int[] yMove) {
            int k, next_x, next_y;
            if (moveNr == N * N)
                return true;

            /* Try all next moves from the current coordinate x, y */
            for (k = 0; k < 8; k++) { //8 => moveArrayLen
                next_x = x + xMove[k];
                next_y = y + yMove[k];
                if (IsAllowedMove(next_x, next_y)) {
                    Squares[next_x, next_y] = moveNr;
                    if (SolveRecursively(next_x, next_y, moveNr + 1, xMove, yMove))
                        return true;
                    else
                        // backtracking
                        Squares[next_x, next_y] = -1;
                }
            }

            return false;
        }

        private bool IsAllowedMove(int x, int y) {
            return (x >= 0 && x < N && y >= 0 && y < N
                    && Squares[x, y] == -1);
        }

        private void PrintSolution() {
            string res = "";
            for (int x = 0; x < N; x++) {
                for (int y = 0; y < N; y++)
                    res += (Squares[x, y] + " ");
                res += "\n";
            }

            Console.WriteLine(res);
        }
    }
}
