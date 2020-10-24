using FluentAssertion.Selenium.Tests.Enums;
using FluentAssertion.Selenium.Tests.Fluent.Hooks;
using FluentAssertion.Selenium.Tests.Settings;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace FluentAssertion.Selenium.Tests.Fluent.Tests.Calculations
{
  [TestFixture]
  public sealed class SampleCalculatorTests : DriverBaseHook
  {

    [OneTimeSetUp]
    public void NavigateToCalculatorExample()
    {
      _driver.Navigate().GoToUrl(FileSettings.WebPageExampleLocation + @"\WebPageExamples\HtmlExamples\CalculatorExamplePage.html");
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
      MathOperations(mathOperator, x, y)
        .Should().Be(int.Parse(result))
        .And.BeOfType(typeof(int));
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
      MathOperations(mathOperator, x, y)
        .Should().Be(int.Parse(result))
        .And.BeOfType(typeof(int));
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
      MathOperations(mathOperator, x, y)
        .Should().Be(int.Parse(result))
        .And.BeOfType(typeof(int));
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
      MathOperations(mathOperator, x, y)
        .Should().Be(int.Parse(result))
        .And.BeOfType(typeof(int));
    }

    [Test, Order(4)]
    public void Forced_Failed_Validation()
    {
      // parsing the first rows of data from the table
      //var mathOperator = _driver.FindElement(By.XPath(".//tbody/tr[4]/td[1]")).Text;
      var x = _driver.FindElement(By.XPath(".//tbody/tr[4]/td[2]")).Text;
      var y = _driver.FindElement(By.XPath(".//tbody/tr[4]/td[3]")).Text;
      var result = _driver.FindElement(By.XPath(".//tbody/tr[4]/td[4]")).Text;


      // Changing the opertor for divide into adding
      // return type to be double
      using (new AssertionScope())
      {
        MathOperations("Add", x, y)
          .Should().Be(int.Parse(result))
          .And.BeOfType(typeof(double));
      }
    }



    private int MathOperations(string mathOperator, string firstValue, string secondValue)
    {
      MathOperators operators = (MathOperators)Enum.Parse(typeof(MathOperators), mathOperator, true);

      int x = int.Parse(firstValue);
      int y = int.Parse(secondValue);

      switch (operators)
      {
        case MathOperators.Add:
          return x + y;
        case MathOperators.Sub:
          return x - y;
        case MathOperators.Divide:
          return y == 0 ? 0 : (int)(x / y);
        case MathOperators.Mutliply:
          return x * y;
        default:
          return 0;

      }
    }
  }
}
