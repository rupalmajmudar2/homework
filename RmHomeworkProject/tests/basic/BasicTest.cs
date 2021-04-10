using NUnit.Framework;

public class BasicTest 
{
    [Test]
    public void TestHello() {
        RmHello hello = new RmHello();
        string greeting = hello.GetHello();
        Assert.AreEqual("Hello Rupal", greeting);
    }
}
