using FluentAssertion.Selenium.Tests.Enums;

namespace FluentAssertion.Selenium.Tests.Interfaces
{
  public interface ICalculator
  {
    int Calculate(MathOperators operators, string firstValue, string secondValue);
    int Calculate(string operators, string firstValue, string secondValue);
    int Calculate(string operators, int firstValue, int secondValue);
  }
}
