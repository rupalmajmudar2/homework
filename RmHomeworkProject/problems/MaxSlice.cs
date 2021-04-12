using System;
using System.Collections.Generic;
using System.Text;

namespace RmHomeworkProject.problems {
    class MaxSlice {
        public int Solution(int[] A) {
            int[] B = GetCumulativeOf(A);
            int maxSum = 0;
            int sum = 0;
            for (int p = 0; p < A.Length; p++) {
                for (int q = p+1; q < A.Length; q++) {
                    sum = B[q] - B[p];
                    if (sum > maxSum) {
                        maxSum = sum;
                    }
                }
            }

            return maxSum;
        }

        private int[] GetCumulativeOf(int[] A) {
            int[] B = new int[A.Length + 1];
            B[0] = 0; ;
            for (int i=1; i < A.Length+1; i++) {
                B[i] = B[i - 1] + A[i - 1];
            }
            return B;
        }
    }
}
