using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class DiscIntersectionsTest {
        [Test]
        public void Test() {
            int[] A = { 1, 5, 2, 1, 4, 0 };

            DiscIntersections di = new DiscIntersections();
            int Xns = di.solution(A);
            Assert.IsTrue(true);
        }
    }
}
