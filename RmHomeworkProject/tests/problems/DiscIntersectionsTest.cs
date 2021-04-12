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
            Assert.AreEqual(11, Xns);

            int[] A2 = { };
            di = new DiscIntersections();
            Xns = di.solution(A2);
            Assert.AreEqual(0, Xns);

            int[] A3 = { 4 };
            di = new DiscIntersections();
            Xns = di.solution(A3);
            Assert.AreEqual(0, Xns);

            int[] A4 = { 4, 2 };
            di = new DiscIntersections();
            Xns = di.solution(A4);
            Assert.AreEqual(1, Xns);
        }
    }
}
