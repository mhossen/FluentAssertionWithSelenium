using NUnit.Framework;

namespace FluentAssertion.Selenium.Tests.Fluent.Hooks.SimpleTests
{
  [TestFixture]
  public class CompareAssertionsTests
  {


    [Test]
    public void SimpleNUnit_AreTextEqual_Test()
    {
      string text = "Hello World";

      Assert.AreEqual(text, "Hello World");
    }

    [Test]
    public void SimpleNUnit_CheckMultiple_Test()
    {
      string text = "Hello World";
      Assert.AreEqual(text, "Hello World");
      Assert.IsTrue(text is string);
    }
  }
}
