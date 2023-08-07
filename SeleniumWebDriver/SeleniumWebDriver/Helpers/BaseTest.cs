using OpenQA.Selenium.Chrome;

namespace MsTests.Helpers
{
    public class BaseTest
    {

        [TestInitialize]
        public virtual void Before()
        {
            Driver.WebDriver = new ChromeDriver();

            Driver.WebDriver.Manage().Window.Maximize();

            //go to main page
            Driver.WebDriver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");
        }

        [TestCleanup]
        public virtual void After()
        {
            Driver.WebDriver.Close();
        }
    }
}
