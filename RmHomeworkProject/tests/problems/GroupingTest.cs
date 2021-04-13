using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class TestGrouping {
        [Test]
        public void Test() {
            Grouping grouping = new Grouping();

            int[] A = { 5, 5, 2, 3, 5, 1, 6 };
            int X = 5;
            int partition = grouping.solution(A, X);
            Assert.AreEqual(4, partition);

            int[] A2 = { 4, 4, 6, 4, 3, 2, 4, 6, 4, 3 };
            int X2 = 4;
            int partition2 = grouping.solution(A2, X2);
            Assert.AreEqual(5, partition2);
        }
    }
}
