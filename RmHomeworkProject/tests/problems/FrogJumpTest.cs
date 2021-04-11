using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class FrogJumpTest {

        [Test]
        public void Test() {
            FrogJump jump = new FrogJump();
            int count = jump.solution(10, 85, 30);
            Assert.AreEqual(3, count);

            count = jump.solution(1, 5, 2);
            Assert.AreEqual(2, count);

            count = jump.solution(5, 5, 2);
            Assert.AreEqual(0, count);
        }
    }
}
