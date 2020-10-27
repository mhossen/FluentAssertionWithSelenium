using FluentAssertion.Selenium.Tests.Fluent.Hooks;
using FluentAssertion.Selenium.Tests.Settings;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FluentAssertion.Selenium.Tests.Fluent.Tests
{
  [TestFixture]
  public class StringEvaluationTests : DriverHook
  {
    private string _message => _driver.FindElement(By.TagName("p")).Text;
    [OneTimeSetUp]
    public void NavigateToCalculatorExample()
    {
      _driver.Navigate().GoToUrl(FileSettings.GetHtmlFileFromAssemblyFolder("StringExample"));
    }


    [Test, Order(1)]
    public void Assert_StartWithWelcomeText_IsDisplayed()
    {
      _message.Should().StartWith("Welcom");
    }

    [Test, Order(2)]
    public void Assert_EndWithUserName_IsDisplayed()
    {
      _message.Should().EndWith("John Smith");
    }

    [Test, Order(3)]
    public void Assert_ContainsUser_IsDisplayed()
    {
      _message.Should().Contain("user");
    }

    [Test, Order(4)]
    public void Assert_Multiple_Chain_IsValid()
    {
      using (new AssertionScope())
      {
        _message.Should().StartWith("Welcom")
          .And.EndWith("John Smith")
          .And.Contain("user");
      }
    }
  }
}
