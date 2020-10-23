using FluentAssertion.Selenium.Tests.Settings;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FluentAssertion.Selenium.Tests.Fluent.Tests.Calculation
{
  [TestFixture]
  public class SampleCalculatorTests
  {
    private IWebDriver _driver;

    [SetUp]
    public void TestSetup()
    {
      new DriverManager().SetUpDriver(new ChromeConfig());
      _driver = new ChromeDriver();
      _driver.Navigate().GoToUrl(FileSettings.WebPageExampleLocation + @"\WebPageExamples\HtmlExamples\CalculatorExamplePage.html");
    }

    [Test]
    public void CalculatorTest()
    {
      System.Console.WriteLine();
    }

    [TearDown]
    public void TestCleanUp()
    {
      if (_driver != null)
      {
        _driver.Quit();
      }
    }
  }
}
