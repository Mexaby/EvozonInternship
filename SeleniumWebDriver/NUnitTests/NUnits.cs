using NUnit.Framework;
using System;
using System.Runtime.Intrinsics.X86;
using System.Text;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(4)]

namespace NUnitTests
{
    public class Tests
    {
        [TestFixture]
        public class Cart
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

    [TestFixture]
    public class Categories
    {
        [Test]
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

    [TestFixture]
    public class Login
    {
        [Test]
        public void UserIntroducedValidLoginCredentials()
        {
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

            //confirmation
            driver.FindElement(By.CssSelector(".hello")).Text.Should().Be("Hello, Andrew 123 Tate!");


            driver.Close();
        }

        [Test]
        public void UserIntroducedTooLongPassword()
        {
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

            string password = Helper.GenerateRandomString(6, 128);
            driver.FindElement(By.Id("pass")).SendKeys(password);
            driver.FindElement(By.Id("send2")).Click();

            driver.FindElement(By.CssSelector(".error-msg span")).Text.Should().Be("Invalid login or password.");

            driver.Close();
        }
    }

    [TestFixture]
    public class Register
    {
        [Test]
        public void UserIntroducedValidRegisterCredentials()
        {
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //go to account > register 
            driver.FindElement(By.CssSelector(".account-cart-wrapper .skip-link.skip-account")).Click();
            driver.FindElement(By.CssSelector("[title=\"Register\"]")).Click();

            string firstName = Helper.GenerateRandomString(1, 256);
            string lastName = Helper.GenerateRandomString(1, 256);
            string password = Helper.GenerateRandomString(1, 256);
            string emailName = Helper.GenerateRandomEmailString(1, 64);
            //string emailHost = Helper.GenerateRandomEmailString(1, 128);

            //fill in the required fields and click register
            driver.FindElement(By.Id("firstname")).SendKeys(firstName);
            driver.FindElement(By.Id("lastname")).SendKeys(lastName);
            driver.FindElement(By.Id("email_address")).SendKeys($"{emailName}@email.com");
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("confirmation")).SendKeys(password);
            driver.FindElement(By.CssSelector(".buttons-set .button")).Click();

            //confirmation
            driver.FindElement(By.CssSelector(".success-msg span")).Text.Should()
                .Be("Thank you for registering with Madison Island.");

            //delete the created user from admin
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/admin");
            driver.FindElement(By.Id("username")).SendKeys("testuser");
            driver.FindElement(By.Id("login")).SendKeys("password123");
            driver.FindElement(By.CssSelector("[title=\"Login\"]")).Click();
            driver.FindElement(By.CssSelector(".message-popup-head a")).Click();
            var action = new Actions(driver);
            var accessoriesElement = driver.FindElements(By.CssSelector("li:nth-child(4) a"))[3];
            action.MoveToElement(accessoriesElement).Perform();
            driver.FindElements(By.CssSelector("li:nth-child(4) ul .level1 a"))[0].Click();
            driver.FindElement(By.CssSelector(".grid tbody tr:nth-child(1) ")).Click();
            driver.FindElements(By.CssSelector(".main-col-inner .content-header p button:nth-child(4) span span span"))[0].Click();
            driver.SwitchTo().Alert().Accept();

            driver.FindElement(By.CssSelector(".messages span")).Text.Should().Be("The customer has been deleted.");

            driver.Close();
        }
    }

    [TestFixture]
    public class Search
    {
        [Test]
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

    [TestFixture]
    public class Wishlist
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

    public class Helper
    {
        private static readonly Random random = new Random();
        public static string GenerateRandomString(int minLength, int maxLength)
        {
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[{]};:'\",<.>/?";

            int length = random.Next(minLength, maxLength + 1);
            char[] randomString = new char[length];
            for (int i = 0; i < length; i++)
            {
                randomString[i] = characters[random.Next(characters.Length)];
            }

            return new string(randomString);
        }

        //exact same method without some forbidden symbols
        public static string GenerateRandomEmailString(int minLength, int maxLength)
        {
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.-_";

            int length = random.Next(minLength, maxLength + 1);
            char[] randomString = new char[length];
            for (int i = 0; i < length; i++)
            {
                randomString[i] = characters[random.Next(characters.Length)];
            }

            return new string(randomString);
        }
    }
}