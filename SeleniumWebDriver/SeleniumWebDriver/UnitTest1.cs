using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumWebDriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidLogin()
        {
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //account > login
            driver.FindElement(By.CssSelector("#header > div > div.skip-links > div > a > span.label")).Click();
            driver.FindElement(By.CssSelector("#header-account > div > ul > li.last > a")).Click();

            //fill in the fields and click login
            driver.FindElement(By.Id("email")).SendKeys("asdf@asdf.com");
            driver.FindElement(By.Id("pass")).SendKeys("111111");
            driver.FindElement(By.Id("send2")).Click();

            //confirmation
            if (driver.FindElement(By.CssSelector(
                    "body > div > div > div.main-container.col2-left-layout > div > div.col-main > div.my-account > div > div.welcome-msg > p.hello > strong")).Text.Equals("Hello, Andrew 123 Tate!"))
            {
                Assert.IsTrue(true, "Test passed.");
            }
            else
            {
                Assert.Fail("Test failed.");
            }

            driver.Close();
        }

    }
}