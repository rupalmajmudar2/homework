﻿using NUnit.Framework;

namespace RmHomeworkProject.algos.sort {

    //https://www.hackerearth.com/practice/algorithms/sorting/bubble-sort/tutorial/
    public class Sort {
        [Test]
        public void TestBubbleSort() {
            Sort sort = new Sort();
            int[] toSort = { 7, 4, 5, 2 };

            int[] bubbleSorted = sort.bubble_sort(toSort);
            Assert.IsNotNull(bubbleSorted);
        }

        public int[] bubble_sort(int[] A) {
            int n = A.Length;
            int temp;
            for (int k = 0; k < n - 1; k++) {
                // (n-k-1) is for ignoring comparisons of elements which have already been compared in earlier iterations

                for (int i = 0; i < n - k - 1; i++) {
                    if (A[i] > A[i + 1]) {
                        // here swapping of positions is being done.
                        temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }

            return A;
        }
    }
}
