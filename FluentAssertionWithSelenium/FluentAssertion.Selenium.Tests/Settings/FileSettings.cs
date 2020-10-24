using System.IO;
using System.Linq;
using System.Reflection;

namespace FluentAssertion.Selenium.Tests.Settings
{
  public class FileSettings
  {
    private static readonly string WebPageExampleLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    public static string GetHtmlFileFromAssemblyFolder(string fileName)
    {
      return Directory.GetFiles(WebPageExampleLocation + @"\WebPageExamples\HtmlExamples")
        .FirstOrDefault(n => n.EndsWith($"{fileName}.html"));
    }
  }
}
