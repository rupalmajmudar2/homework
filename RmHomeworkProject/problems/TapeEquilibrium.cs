using System;
using System.Collections.Generic;
using System.Text;

namespace RmHomeworkProject.problems {
    class TapeEquilibrium {
        public int solution(int[] A) {
            int leftSum = 0;
            int rightSum = arraySum(A);
            int minAbsDiff = Int32.MaxValue;

            for (int p=0; p < A.Length; p++) {
                leftSum = leftSum + A[p];
                rightSum = rightSum - A[p];
                int absDiff = Math.Abs(leftSum - rightSum);
                if (absDiff < minAbsDiff) {
                    minAbsDiff = absDiff;
                }
            }

            return minAbsDiff;
        }

        private int arraySum(int[] A) {
            int sum = 0;
            for (int i=0; i < A.Length; i++) {
                sum += A[i];
            }

            return sum;
        }
    }
}
