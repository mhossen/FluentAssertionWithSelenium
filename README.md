# FluentAssertion With Selenium

***Notes:*** *This tests project doesn't focus on building a framework for Selenium, but uses selenium library with Fluent Assertion library to demonstrate uses for Assertion.*

<br/>

|Packages|Version|
|:---|---:|
|Target Framework |netcoreapp2.2|
|FluentAssertions|5.10.3|
|nunit|3.12.0|
|NUnit3TestAdapter|3.17.0|
|Selenium.Support|3.14.0|
|Selenium.WebDriver|3.14.0|
|WebDriverManager|2.11.0|

<br/>
Before running this project I would check for the .Net SDK installed on my machine then either right click on the project name in Visual Studio Solution Explorer --> Properties --> Application and change the Target framework. Or you can follow the instruction on the following link <a href="https://www.tutorialsteacher.com/core/target-multiple-frameworks-in-aspnet-core2">How to target Multiple Framework</a> to change at <code>.csproj</code> file.

<br/>

<img src="https://github.com/mhossen/FluentAssertionWithSelenium/blob/support-multi-framework/FluentAssertionWithSelenium/FluentAssertion.Selenium.Tests/Images/TrageFramework.jpg" alt="Target Framework" width="350" height="250"/>
<br/>

### Text Compare
<code>
string welcomeMessage = "<p>Welcome user John Smith</p>";
var actualMessage = driver.FindElement(By.TagName("p")).Text;
<br/>
actualMessage.Should().StartWith("Welcome").And.EndWith("John Smith").And.Contain("user");
</cod>

[Fluent Assertion Official Documentation](https://fluentassertions.com/introduction)