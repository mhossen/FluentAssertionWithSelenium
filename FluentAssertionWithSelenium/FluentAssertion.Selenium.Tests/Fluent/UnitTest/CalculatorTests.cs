using FluentAssertion.Selenium.Tests.Interfaces;
using FluentAssertion.Selenium.Tests.Utility;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using System;

namespace FluentAssertion.Selenium.Tests.Fluent.UnitTest
{

  public class CalculatorTests
  {
    private ICalculator _calculator;

    [OneTimeSetUp]
    public void Setup()
    {
      _calculator = new Calculator();
    }

    [Test]
    public void Expected_ArgumentException()
    {
      // Math Operator Enum type match based on string
      string mathOperation = "somethingfornothing";

      // Assert when Math Operation string type doesn't match it should throw an Argument Exception with message is optional
      using (new AssertionScope())
      {
        _calculator.Invoking(c => c.Calculate(mathOperation, 1, 2))
          .Should().Throw<ArgumentException>()
          .WithMessage($@"Requested value '{mathOperation}' was not found.");
      }
    }


    [Test]
    public void Expected_ArgumentException_WithMessage_IsValid()
    {
      string mathOperation = "abs";

      using (new AssertionScope())
      {
        _calculator.Invoking(c => c.Calculate(mathOperation, 1, 2))
          .Should().Throw<ArgumentException>()
          .WithMessage($"Operator provided was {mathOperation} not implemented");
      }
    }


    [Test]
    public void Verify_Interface_IsImplemented()
    {
      typeof(Calculator).Should()
        .Implement<ICalculator>();
    }
  }
}
