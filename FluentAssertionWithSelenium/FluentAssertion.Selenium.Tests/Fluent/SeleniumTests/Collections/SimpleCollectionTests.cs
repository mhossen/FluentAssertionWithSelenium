﻿using FluentAssertion.Selenium.Tests.Fluent.Hooks;
using FluentAssertion.Selenium.Tests.Settings;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace FluentAssertion.Selenium.Tests.Fluent.SeleniumTests.Collections
{
  [TestFixture]
  class SimpleCollectionTests : DriverHook
  {
    private IList<IWebElement> _unorderedList => _driver.FindElements(By.XPath(".//ul[@id='unorderedList']/li"));
    [OneTimeSetUp]
    public void NavigateToAmazon()
    {
      _driver.Navigate().GoToUrl(FileSettings.GetHtmlFileFromAssemblyFolder("Lists"));
    }

    [Test, Order(1)]
    public void Confirm_ItemList_IsUnique()
    {
      _unorderedList.Select(t => t.Text)
        .Should().OnlyHaveUniqueItems();
    }

    [TestCase("Apple")]
    [TestCase("Orange")]
    [TestCase("Pomegranate")]
    [Order(2)]
    public void Comfirm_ItemList_HasValue(string fruit)
    {
      _unorderedList.Select(t => t.Text)
        .Should().Contain(fruit);
    }

    [Test]
    public void Confirm_ItemList_IsAscendingOrder()
    {
      // Assert to check if text is ascending order
      _unorderedList.Select(t => t.Text).Should()
        .BeInAscendingOrder();
    }

  }
}
