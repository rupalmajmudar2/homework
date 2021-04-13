
using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class TopTal3Test {
        [Test]
        public void Test() {
            TopTal3 test3 = new TopTal3();
            int[] A = { 3, 1, 2, 4, 3 };
            int soln = test3.solution(A);
            Assert.IsTrue(true);
        }
    }
}
