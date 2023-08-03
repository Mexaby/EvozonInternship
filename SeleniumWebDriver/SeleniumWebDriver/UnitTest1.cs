using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumWebDriver
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void UserIntroducedCorrectLoginCredentials()
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
                    "body > div > div > div.main-container.col2-left-layout > div > div.col-main > div.my-account > div > div.welcome-msg > p.hello > strong"))
                .Text.Equals("Hello, Andrew 123 Tate!"))
            {
                Assert.IsTrue(true, "Test passed.");
            }
            else
            {
                Assert.Fail("Test failed.");
            }

            driver.Close();
        }

        [TestMethod]
        public void UserIntroducedWrongLoginCredentials()
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
            driver.FindElement(By.Id("pass")).SendKeys("11111");
            driver.FindElement(By.Id("send2")).Click();

            if (driver.Url.Equals("http://qa2magento.dev.evozon.com/customer/account/login/"))
            {
                Assert.IsTrue(true, "Test passed.");
            }
            else
            {
                Assert.Fail("Test failed.");
            }

            driver.Close();
        }

        [TestMethod]
        public void NavigateMainCategories()
        {
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //access women's main category and return to home page
            driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-1.first.parent > a")).Click();
            driver.FindElement(By.CssSelector("#header > div > a > img.large")).Click();

            //access men's main category and return to home page
            driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-2.parent > a")).Click();
            driver.FindElement(By.CssSelector("#header > div > a > img.large")).Click();

            //access accessories main category and return to home page
            driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-3.parent > a")).Click();
            driver.FindElement(By.CssSelector("#header > div > a > img.large")).Click();

            //access home & decor main category and return to home page
            driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-4.parent > a")).Click();
            driver.FindElement(By.CssSelector("#header > div > a > img.large")).Click();

            //access sale main category and return to home page
            driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-5.parent > a")).Click();
            driver.FindElement(By.CssSelector("#header > div > a > img.large")).Click();

            //access vip main category and return to home page
            driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-6.last > a")).Click();
            driver.FindElement(By.CssSelector("#header > div > a > img.large")).Click();

            driver.Close();
        }

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
            driver.FindElement(By.CssSelector("#search_mini_form > div.input-box > button")).Click();

            if (driver.FindElement(By.CssSelector("body > div > div > div.main-container.col3-layout > div > div.col-wrapper > div.col-main > div.page-title > h1")).Text.Equals("SEARCH RESULTS FOR 'RED'"))
            {
                Assert.IsTrue(true, "Test passed.");
            }
            else
            {
                Assert.Fail("Test failed.");
            }

            driver.Close();
        }

        [TestMethod]
        public void UserIntroducedValidRegisterCredentials()
        {
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //go to account > register 
            driver.FindElement(By.CssSelector("#header > div > div.skip-links > div > a > span.label")).Click();
            driver.FindElement(By.CssSelector("#header-account > div > ul > li:nth-child(5) > a")).Click();

            //fill in the required fields and click register
            driver.FindElement(By.Id("firstname")).SendKeys("auto");
            driver.FindElement(By.Id("lastname")).SendKeys("testing");
            driver.FindElement(By.Id("email_address")).SendKeys("qwe@qwe.com");
            driver.FindElement(By.Id("password")).SendKeys("asdasd");
            driver.FindElement(By.Id("confirmation")).SendKeys("asdasd");
            driver.FindElement(By.CssSelector("#form-validate > div.buttons-set > button")).Click();

            //confirmation
            if (driver.FindElement(By.CssSelector(
                    "body > div > div > div.main-container.col2-left-layout > div > div.col-main > div.my-account > div > ul > li > ul > li > span"))
                .Text.Equals("Thank you for registering with Madison Island."))
            {
                Assert.IsTrue(true, "Test passed.");
            }
            else
            {
                Assert.Fail("Test failed.");
            }

            //delete the created user from admin
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/admin");
            driver.FindElement(By.Id("username")).SendKeys("testuser");
            driver.FindElement(By.Id("login")).SendKeys("password123");
            driver.FindElement(By.CssSelector("#loginForm > div > div.form-buttons > input")).Click();
            driver.FindElement(By.CssSelector("#message-popup-window > div.message-popup-head > a > span")).Click();
            var action = new Actions(driver);
            var accessoriesElement = driver.FindElement(By.CssSelector("#nav > li:nth-child(4) > a > span"));
            action.MoveToElement(accessoriesElement).Perform();
            driver.FindElement(By.CssSelector("#nav > li:nth-child(4) > ul > li:nth-child(1) > a > span")).Click();
            driver.FindElement(By.CssSelector("#customerGrid_table > tbody > tr:nth-child(1)")).Click();
            driver.FindElements(By.CssSelector(".main-col-inner .content-header p button:nth-child(4) span span span"))[0].Click();
            driver.SwitchTo().Alert().Accept();

            driver.Close();
        }

        [TestMethod]
        public void AddAnyItemToWishlist()
        {
            //must be logged in in order to use the wishlist feature
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

            //access a sub-category
            var action = new Actions(driver);
            var accessoriesElement = driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-3.parent > a"));
            action.MoveToElement(accessoriesElement).Perform();
            driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-3.parent > ul > li.level1.nav-3-3 > a")).Click();

            //add some item to wishlist
            driver.FindElement(By.CssSelector("body > div > div > div.main-container.col3-layout > div > div.col-wrapper > div.col-main > div.category-products > ul > li:nth-child(8) > div > div.actions > ul > li:nth-child(1) > a")).Click();

            //confirmation
            if (driver.FindElement(By.CssSelector(
                    "body > div > div > div.main-container.col2-left-layout > div > div.col-main > div.my-account > div.my-wishlist > ul > li > ul > li > span"))
                .Text.Equals("Flip flops has been added to your wishlist. Click here to continue shopping."))
            {
                Assert.IsTrue(true, "Test passed.");
            }
            else
            {
                Assert.Fail("Test failed.");
            }

            driver.Close();
        }

        [TestMethod]
        public void RemoveLastItemFromWishlist()
        {
            //first we must add an element to the wishlist to delete it, so we copy all from the previous method, with a different item this time 
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //account > login
            driver.FindElement(By.CssSelector("#header > div > div.skip-links > div > a > span.label")).Click();
            driver.FindElement(By.CssSelector("#header-account > div > ul > li.last > a")).Click();

            //fill in the fields and click login
            driver.FindElement(By.Id("email")).SendKeys("asd@asd.com");
            driver.FindElement(By.Id("pass")).SendKeys("asdasd");
            driver.FindElement(By.Id("send2")).Click();

            //access a sub-category
            var action = new Actions(driver);
            var accessoriesElement = driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-2.parent > a"));
            action.MoveToElement(accessoriesElement).Perform();
            driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-2.parent > ul > li.level1.nav-2-2 > a")).Click();

            //add some item to wishlist
            driver.FindElement(By.CssSelector("body > div > div > div.main-container.col1-layout > div > div.col-main > div.category-products > ul > li:nth-child(3) > div > div.actions > ul > li:nth-child(1) > a")).Click();

            //remove the item and press ok in the confirmation box
            driver.FindElement(By.CssSelector(".btn-remove.btn-remove2")).Click();
            driver.SwitchTo().Alert().Accept();

            //confirmation
            if (driver.FindElement(By.CssSelector("#wishlist-view-form > div > p")).Text
                .Equals("You have no items in your wishlist."))
            {
                Assert.IsTrue(true, "Test passed.");
            }
            else
            {
                Assert.Fail("Test failed.");
            }

            driver.Quit();
        }

        [TestMethod]
        public void WishlistItemWithoutLogin()
        {
            //try to wishlist an item right away
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //access a sub-category
            var action = new Actions(driver);
            var accessoriesElement = driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-1.first.parent > a"));
            action.MoveToElement(accessoriesElement).Perform();
            driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-1.first.parent > ul > li.level1.nav-1-4.last > a")).Click();

            //try to add item to wishlist, will take you to login page
            driver.FindElement(By.CssSelector("body > div > div > div.main-container.col3-layout > div > div.col-wrapper > div.col-main > div.category-products > ul > li:nth-child(2) > div > div.actions > ul > li:nth-child(1) > a")).Click();

            if (driver.Url.Equals("http://qa2magento.dev.evozon.com/customer/account/login/"))
            {
                Assert.IsTrue(true, "Test passed.");
            }
            else
            {
                Assert.Fail("Test failed.");
            }

            driver.Close();
        }

        [TestMethod]
        public void AddConfigurableItemToCart()
        {
            //initialize driver
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //go to main page
            driver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/");

            //access a sub-category
            var action = new Actions(driver);
            var accessoriesElement = driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-1.first.parent > a"));
            action.MoveToElement(accessoriesElement).Perform();
            driver.FindElement(By.CssSelector("#nav > ol > li.level0.nav-1.first.parent > ul > li.level1.nav-1-4.last > a")).Click();

            //view item, select configurable options and add it to the cart
            driver.FindElement(By.CssSelector("body > div > div > div.main-container.col3-layout > div > div.col-wrapper > div.col-main > div.category-products > ul > li:nth-child(2) > div > div.actions > a")).Click();
            driver.FindElement(By.CssSelector("#swatch18 > span.swatch-label > img")).Click();
            driver.FindElement(By.CssSelector("#swatch80 > span.swatch-label")).Click();
            driver.FindElement(By.CssSelector("#product_addtocart_form > div.product-shop > div.product-options-bottom > div.add-to-cart > div.add-to-cart-buttons > button")).Click();

            //confirmation
            if (driver.FindElement(By.CssSelector(
                    "body > div > div > div.main-container.col1-layout > div > div > div.cart.display-single-price > ul > li > ul > li > span"))
                .Text.Equals("Racer Back Maxi Dress was added to your shopping cart."))
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