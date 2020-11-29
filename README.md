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
|||

<br/>
Before running this project I would check for the .Net SDK installed on my machine then either right click on the project name in <code> Visual Studio Solution Explorer --> Properties --> Application</code> and change the Target framework. Or you can follow the instruction on the following link <a href="https://www.tutorialsteacher.com/core/target-multiple-frameworks-in-aspnet-core2">How to target Multiple Framework</a> to change at <code>.csproj</code> file.

<br/>

### Text Evaluation

```csharp
string message = "Welcome user John Smith";
```

#### Start With
Evaluates string starts with specific character(s) from the above example if we want to check if the message has the word `Welcome`.

```csharp
message.Should().StartWith("Welcome");
```


#### End With
Evaluates string ends with specific character(s) from the above example if we want to check if the message has `John Smith`.

```csharp
message.Should().EndWith("John Smith");
```

#### Contains
Evaluates that string contains a series of character(s) from above example if we want to check if the word `user` exist.

```csharp
message.Should().Contain("user");
```

#### Assertion Scope
Assertion Scope batches multiple assertions so that when evaluating multiple facts, `FluentAssertions` throws one collective exception summary at the end of the scope for all failures. 

```csharp
using (new AssertionScope())
{
    message.Should().StartWith("Welcome")
    .And.EndWith("John Smith")
    .And.Contain("user");
}
```
<br/>

## Working With Collections
```html
    <ul class="list-group" id="unorderedList">
      <li class="list-group-item">Apple</li>
      <li class="list-group-item">Orange</li>
      <li class="list-group-item">Lychee</li>
      <li class="list-group-item">Pomegranate</li>
      <li class="list-group-item">Watermelon</li>
      <li class="list-group-item">Mangosteen</li>
    </ul>
```

```csharp
```

[Fluent Assertion Official Documentation](https://fluentassertions.com/introduction)