using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace NUnitTests.Tests
{
    [TestFixture]
    public class CartTest
    {
        [Test]
        public void AddConfigurableItemToCart()
        {
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //access a sub-category
            var action = new Actions(driver);
            var accessoriesElement = driver.FindElement(By.CssSelector(".level0.nav-1 a"));
            action.MoveToElement(accessoriesElement).Perform();
            driver.FindElement(By.CssSelector(".level1.nav-1-4 a")).Click();

            //view item, select configurable options and add it to the cart
            driver.FindElements(By.CssSelector(".product-info .actions .button "))[1].Click();
            driver.FindElement(By.CssSelector("#swatch18 .swatch-label")).Click();
            driver.FindElement(By.CssSelector("#swatch80 .swatch-label")).Click();
            driver.FindElement(By.CssSelector(".add-to-cart-buttons .button")).Click();

            //confirmation
            driver.FindElement(By.CssSelector(".success-msg span")).Text.Should()
                .Be("Racer Back Maxi Dress was added to your shopping cart.");

            driver.Close();
        }
    }
}
