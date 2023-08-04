using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTests.Tests
{
    [TestClass]
    public class CategoryNavigationTests
    {
        [TestMethod]
        public void NavigateMainCategories()
        {
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //access women's main category and return to home page
            driver.FindElement(By.CssSelector(".level0.nav-1 a")).Click();
            driver.FindElement(By.CssSelector("#header .large")).Click();

            //access men's main category and return to home page
            driver.FindElement(By.CssSelector(".level0.nav-2 a")).Click();
            driver.FindElement(By.CssSelector("#header .large")).Click();

            //access accessories main category and return to home page
            driver.FindElement(By.CssSelector(".level0.nav-3 a")).Click();
            driver.FindElement(By.CssSelector("#header .large")).Click();

            //access home & decor main category and return to home page
            driver.FindElement(By.CssSelector(".level0.nav-4 a")).Click();
            driver.FindElement(By.CssSelector("#header .large")).Click();

            //access sale main category and return to home page
            driver.FindElement(By.CssSelector(".level0.nav-5 a")).Click();
            driver.FindElement(By.CssSelector("#header .large")).Click();

            //access vip main category and return to home page
            driver.FindElement(By.CssSelector(".level0.nav-6 a")).Click();
            driver.FindElement(By.CssSelector("#header .large")).Click();

            driver.Close();
        }
    }
}
