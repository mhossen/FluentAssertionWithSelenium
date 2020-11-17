using FluentAssertion.Selenium.Tests.Enums;
using FluentAssertion.Selenium.Tests.Interfaces;
using System;

namespace FluentAssertion.Selenium.Tests.Utility
{
  public class Calculator : ICalculator
  {
    public int Calculate(MathOperators operators, string firstValue, string secondValue)
    {
      int.TryParse(firstValue, out int x);
      int.TryParse(secondValue, out int y);

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
          throw new ArgumentException($"Operator provided was not implemented");
      }
    }

    public int Calculate(string operators, string firstValue, string secondValue)
    {
      int.TryParse(firstValue, out int x);
      int.TryParse(secondValue, out int y);
      MathOperators switcthableOperators = (MathOperators)Enum.Parse(typeof(MathOperators), operators, true);

      switch (switcthableOperators)
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
          throw new ArgumentException($"Operator provided was not implemented");
      }
    }

    public int Calculate(string operators, int x, int y)
    {
      var math = (MathOperators)Enum.Parse(typeof(MathOperators), operators, true);

      switch (math)
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
          throw new ArgumentException($"Operator provided was {operators} not implemented");
      }
    }
  }
}
