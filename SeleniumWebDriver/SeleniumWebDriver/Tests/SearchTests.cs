using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace NUnitTests.Tests
{

    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        public void SearchForKeyword()
        {
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //insert something in the search bar and press the search button
            driver.FindElement(By.Id("search")).SendKeys("red");
            driver.FindElement(By.CssSelector(".search-button")).Click();

            driver.FindElement(By.CssSelector(".page-title h1")).Text.Should().Be("SEARCH RESULTS FOR 'RED'");

            driver.Close();
        }
    }
}
