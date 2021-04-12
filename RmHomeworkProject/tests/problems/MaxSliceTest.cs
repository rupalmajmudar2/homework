using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class MaxSliceTest {

        [Test]
        public void Test() {
            int[] A = { 5, -7, 3, 5, -2, 4, -1 };
            MaxSlice slice = new MaxSlice();
            int maxSum = slice.Solution(A);
            Assert.AreEqual(10, maxSum);

            int[] A2 = { 3, 2, -6, 4, 0 };
            int maxSum2 = slice.Solution(A2);
            Assert.AreEqual(5, maxSum2);
        }
    }
}
