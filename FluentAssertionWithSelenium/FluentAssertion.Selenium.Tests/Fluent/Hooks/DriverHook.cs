﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(5)]

namespace FluentAssertion.Selenium.Tests.Fluent.Hooks
{

  [SetUpFixture]
  public abstract class DriverHook
  {
    protected IWebDriver _driver;


    [OneTimeSetUp]
    public void BrowserSetup()
    {
      if (_driver is null)
      {
        new DriverManager().SetUpDriver(new ChromeConfig());
        _driver = new ChromeDriver();
      }

    }

    [OneTimeTearDown]
    public void TestCleanUp()
    {
      _driver?.Close();
      _driver?.Quit();
    }

  }
}
