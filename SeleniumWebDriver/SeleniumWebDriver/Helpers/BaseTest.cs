using System.Reflection;
using NsTestFrameworkUI.Helpers;

[assembly: Parallelize(Workers = 4, Scope = ExecutionScope.MethodLevel)]
namespace MsTests.Helpers
{
    public class BaseTest
    {
        [TestInitialize]
        public virtual void Before()
        {
            Browser.InitializeDriver(new DriverOptions
            {
                IsHeadless = false,
                ChromeDriverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
            });
            Browser.GoTo("http://qa2magento.dev.evozon.com/");
            Browser.WebDriver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public virtual void After()
        {
            Browser.Cleanup();
        }
    }
}
