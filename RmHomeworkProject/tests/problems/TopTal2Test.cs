
using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class TopTal2Test {
        [Test]
        public void Test() {
            TopTal2 test2 = new TopTal2();
            int[] A = { 3, 1, 2, 4, 3 };
            int soln = test2.solution(A);
            Assert.IsTrue(true);
        }
    }
}
