using FluentAssertion.Selenium.Tests.Fluent.Hooks;
using FluentAssertion.Selenium.Tests.Interfaces;
using FluentAssertion.Selenium.Tests.Settings;
using FluentAssertion.Selenium.Tests.Utility;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FluentAssertion.Selenium.Tests.Fluent.SeleniumTests.Calculations
{
  [TestFixture]
  public sealed class SampleCalculatorTests : DriverHook
  {
    private ICalculator _calculator;

    [OneTimeSetUp]
    public void NavigateToCalculatorExample()
    {
      _driver.Navigate().GoToUrl(FileSettings.GetHtmlFileFromAssemblyFolder("CalculatorExamplePage"));
      _calculator = new Calculator();
    }

    [Test, Order(1)]
    public void Multiply_XwithY_IsValidExpectedResult()
    {
      // parsing the first rows of data from the table
      var mathOperator = _driver.FindElement(By.XPath(".//tbody/tr[1]/td[1]")).Text;
      var x = _driver.FindElement(By.XPath(".//tbody/tr[1]/td[2]")).Text;
      var y = _driver.FindElement(By.XPath(".//tbody/tr[1]/td[3]")).Text;
      var result = _driver.FindElement(By.XPath(".//tbody/tr[1]/td[4]")).Text;

      // Asserting that Expected Results column matches based on multiplied values x with y
      // And checking to make sure the value is a type of int
      using (new AssertionScope())
      {
        _calculator.Calculate(mathOperator, x, y)
        .Should().Be(int.Parse(result))
        .And.BeOfType(typeof(int));
      }
    }

    [Test, Order(2)]
    public void Add_XwithY_IsValidExpectedResult()
    {
      // parsing the first rows of data from the table
      var mathOperator = _driver.FindElement(By.XPath(".//tbody/tr[2]/td[1]")).Text;
      var x = _driver.FindElement(By.XPath(".//tbody/tr[2]/td[2]")).Text;
      var y = _driver.FindElement(By.XPath(".//tbody/tr[2]/td[3]")).Text;
      var result = _driver.FindElement(By.XPath(".//tbody/tr[2]/td[4]")).Text;

      // Asserting that Expected Results column matches based on adding values x with y
      // And checking to make sure the value is a type of int
      using (new AssertionScope())
      {
        _calculator.Calculate(mathOperator, x, y)
        .Should().Be(int.Parse(result))
        .And.BeOfType(typeof(int));
      }
    }

    [Test, Order(3)]
    public void Sub_XwithY_IsValidExpectedResult()
    {
      // parsing the first rows of data from the table
      var mathOperator = _driver.FindElement(By.XPath(".//tbody/tr[3]/td[1]")).Text;
      var x = _driver.FindElement(By.XPath(".//tbody/tr[3]/td[2]")).Text;
      var y = _driver.FindElement(By.XPath(".//tbody/tr[3]/td[3]")).Text;
      var result = _driver.FindElement(By.XPath(".//tbody/tr[3]/td[4]")).Text;

      // Asserting that Expected Results column matches based on subtracting y from x
      // And checking to make sure the value is a type of int
      using (new AssertionScope())
      {
        _calculator.Calculate(mathOperator, x, y)
        .Should().Be(int.Parse(result))
        .And.BeOfType(typeof(int));
      }
    }

    [Test, Order(4)]
    public void Dividing_XwithY_IsValidExpectedResult()
    {
      // parsing the first rows of data from the table
      var mathOperator = _driver.FindElement(By.XPath(".//tbody/tr[4]/td[1]")).Text;
      var x = _driver.FindElement(By.XPath(".//tbody/tr[4]/td[2]")).Text;
      var y = _driver.FindElement(By.XPath(".//tbody/tr[4]/td[3]")).Text;
      var result = _driver.FindElement(By.XPath(".//tbody/tr[4]/td[4]")).Text;

      // Asserting that Expected Results column matches based on diving value of x with y
      // And checking to make sure the value is a type of int
      using (new AssertionScope())
      {
        _calculator.Calculate(mathOperator, x, y)
          .Should().Be(int.Parse(result))
          .And.BeOfType(typeof(int));
      }
    }

    [Test, Order(4)]
    public void Forced_Failed_Validation()
    {
      // parsing the first rows of data from the table
      var x = _driver.FindElement(By.XPath(".//tbody/tr[4]/td[2]")).Text;
      var y = _driver.FindElement(By.XPath(".//tbody/tr[4]/td[3]")).Text;
      var result = _driver.FindElement(By.XPath(".//tbody/tr[4]/td[4]")).Text;

      // Changing the opertor for divide into adding
      // return type to be double
      using (new AssertionScope())
      {
        _calculator.Calculate("Add", x, y)
          .Should().Be(int.Parse(result))
          .And.BeOfType(typeof(double));
      }
    }
  }
}
