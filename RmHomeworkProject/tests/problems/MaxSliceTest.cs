using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class MaxSliceTest {

        //https://funnelgarden.com/maxslicesum-codility-solution/
        //The problem is to find the maximum sum of a sub-array of a given integer array.
        [Test]
        public void Test() {
            int[] A = { 5, -7, 3, 5, -2, 4, -1 };
            MaxSlice slice = new MaxSlice();
            int maxSum = slice.Solution(A);
            Assert.AreEqual(10, maxSum);
            //This happens when the slice is at 3, 5, -2, 4) total = 10
            //i.e. sum -2 : 9

            int[] A2 = { 3, 2, -6, 4, 0 };
            int maxSum2 = slice.Solution(A2);
            Assert.AreEqual(5, maxSum2);
        }
    }
}
