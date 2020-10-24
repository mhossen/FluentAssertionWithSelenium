using FluentAssertion.Selenium.Tests.Fluent.Hooks;
using NUnit.Framework;

namespace FluentAssertion.Selenium.Tests.Fluent.Tests.Collections
{
  [TestFixture]
  class SimpleUnorderdCollectionTests : DriverBaseHook
  {

    [OneTimeSetUp]
    public void NavigateToAmazon()
    {
      _driver.Navigate().GoToUrl("https://amazon.com/");
    }

    [Test]
    public void TestRunner()
    {
      System.Console.WriteLine(_driver.Url);
    }
  }
}
