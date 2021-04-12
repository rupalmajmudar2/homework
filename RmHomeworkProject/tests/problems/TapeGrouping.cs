using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class TestGrouping {
        [Test]
        public void Test() {
            int[] A = { 5, 5, 2, 3, 5, 1, 6 };
            int X = 5;

            Grouping grouping = new Grouping();
            int partition = grouping.solution(A, X);
            Assert.AreEqual(4, partition);
        }
    }
}
