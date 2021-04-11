using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class TapeEquilibriumTest {
        [Test]
        public void Test() {
            TapeEquilibrium tape = new TapeEquilibrium();
            int[] A = { 3, 1, 2, 4, 3 };
            int min = tape.solution(A);
            Assert.AreEqual(1, min);

            int[] A2 = { 1, 1, 1, 1, 1 };
            min = tape.solution(A2);
            Assert.AreEqual(1, min);

            int[] A3 = { 1, 1, 1, 1, 1, 1 };
            min = tape.solution(A3);
            Assert.AreEqual(0, min);

            int[] A4 = { 20, 30 };
            min = tape.solution(A4);
            Assert.AreEqual(10, min);

            int[] A5 = { 20 };
            min = tape.solution(A5);
            Assert.AreEqual(20, min);
        }
    }
}
