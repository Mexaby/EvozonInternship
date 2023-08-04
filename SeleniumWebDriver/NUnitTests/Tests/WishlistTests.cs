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
    public class WishlistTests
    {
        [Test]
        public void AddAnyItemToWishlist()
        {
            //must be logged in in order to use the wishlist feature
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //account > login
            driver.FindElement(By.CssSelector(".account-cart-wrapper .skip-link.skip-account")).Click();
            driver.FindElement(By.CssSelector("#header-account .last a")).Click();

            //fill in the fields and click login
            driver.FindElement(By.Id("email")).SendKeys("asdf@asdf.com");
            driver.FindElement(By.Id("pass")).SendKeys("111111");
            driver.FindElement(By.Id("send2")).Click();

            //access a sub-category
            var action = new Actions(driver);
            var accessoriesElement = driver.FindElement(By.CssSelector(".level0.nav-3 a"));
            action.MoveToElement(accessoriesElement).Perform();
            driver.FindElement(By.CssSelector(".level1.nav-3-3 a")).Click();

            //add some item to wishlist
            driver.FindElements(By.CssSelector(".link-wishlist"))[7].Click();

            //confirmation
            driver.FindElement(By.CssSelector(".success-msg span")).Text.Should().Be("Flip flops has been added to your wishlist. Click here to continue shopping.");

            driver.Close();
        }

        [Test]
        public void RemoveLastItemFromWishlist()
        {
            //first we must add an element to the wishlist to delete it, so we copy all from the previous method, with a different item this time 
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //account > login
            driver.FindElement(By.CssSelector(".account-cart-wrapper .skip-link.skip-account")).Click();
            driver.FindElement(By.CssSelector("#header-account .last a")).Click();

            //fill in the fields and click login
            driver.FindElement(By.Id("email")).SendKeys("asd@asd.com");
            driver.FindElement(By.Id("pass")).SendKeys("asdasd");
            driver.FindElement(By.Id("send2")).Click();

            //access a sub-category
            var action = new Actions(driver);
            var accessoriesElement = driver.FindElement(By.CssSelector(".level0.nav-2 a"));
            action.MoveToElement(accessoriesElement).Perform();
            driver.FindElement(By.CssSelector(".level1.nav-2-2")).Click();

            //add some item to wishlist
            driver.FindElements(By.CssSelector(".link-wishlist"))[3].Click();

            //remove the item and press ok in the confirmation box
            driver.FindElement(By.CssSelector(".btn-remove.btn-remove2")).Click();
            driver.SwitchTo().Alert().Accept();

            //confirmation
            driver.FindElement(By.CssSelector(".wishlist-empty")).Text.Should().Be("You have no items in your wishlist.");

            driver.Quit();
        }

        [Test]
        public void AddItemToWishlistWithoutLogin()
        {
            //try to wishlist an item right away
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //access a sub-category
            var action = new Actions(driver);
            var accessoriesElement = driver.FindElement(By.CssSelector(".level0.nav-2 a"));
            action.MoveToElement(accessoriesElement).Perform();
            driver.FindElement(By.CssSelector(".level1.nav-2-2")).Click();

            //add some item to wishlist
            driver.FindElements(By.CssSelector(".link-wishlist"))[3].Click();

            driver.FindElement(By.CssSelector(".page-title h1")).Text.Should().Be("LOGIN OR CREATE AN ACCOUNT");

            driver.Close();
        }
    }
}
