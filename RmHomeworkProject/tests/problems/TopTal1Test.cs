
using NUnit.Framework;

using RmHomeworkProject.problems;

namespace RmHomeworkProject.tests.problems {
    class TopTal1Test {
        [Test]
        public void Test() {
            Result test1 = new Result();
            string s = "tacocat";
            int count = Result.countPalindromes(s);
            Assert.AreEqual(10, count);

            s = "";
            count = Result.countPalindromes(s);
            Assert.AreEqual(0, count);

            s = "a";
            count = Result.countPalindromes(s);
            Assert.AreEqual(1, count);

            s = "sa";
            count = Result.countPalindromes(s);
            Assert.AreEqual(2, count);

            s = "ss";
            count = Result.countPalindromes(s);
            Assert.AreEqual(3, count);
        }
    }
}
