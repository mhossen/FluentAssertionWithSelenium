using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertion.Selenium.Tests.Fluent.Hooks.SimpleTests
{
  [TestFixture, Parallelizable(ParallelScope.Children)]
  public class TextEvaluationTests
  {
    private readonly string _message = "Welcome user John Smith";

    [Test]
    public void Evaluate_TextStartWith_IsValid()
    {
      _message.Should()
        .StartWith("Welcome");
    }

    [Test]
    public void Evaluate_TextContains_IsValid()
    {
      _message.Should()
        .Contain("user");
    }

    [Test]
    public void Evaluate_TextEndWith_IsValid()
    {
      _message.Should()
        .EndWith("John Smith");
    }
  }
}
