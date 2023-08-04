using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTests.Helpers
{
    public class BaseTest
    {

        [TestInitialize]
        public void Before()
        {
            Driver.WebDriver = new ChromeDriver();

            Driver.WebDriver.Manage().Window.Maximize();

            //go to main page
            Driver.WebDriver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");
        }

        [TestCleanup]
        public void After()
        {
            Driver.WebDriver.Close();
        }
    }
}
