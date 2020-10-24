using System.IO;
using System.Reflection;

namespace FluentAssertion.Selenium.Tests.Settings
{
  public class FileSettings
  {
    public static string WebPageExampleLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
  }
}
