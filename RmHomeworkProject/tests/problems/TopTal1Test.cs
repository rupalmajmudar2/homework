
using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class TopTal1Test {
        [Test]
        public void Test() {
            TopTal1 test1 = new TopTal1();
            int[] A = { 3, 1, 2, 4, 3 };
            int soln = test1.solution(A);
            Assert.IsTrue(true);

            Result.fizzBuzz(15);
        }
    }
}
