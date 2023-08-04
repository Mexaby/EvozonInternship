using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using FluentAssertions;

namespace NUnitTests.Tests
{
    [TestFixture]
    public class RegisterTests
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

            string firstName = Name.First();
            string lastName = Name.Last();
            string password = StringFaker.Randomize("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[{]};:'\",<.>/?");
            string email = Internet.Email();

            //string emailHost = Helper.GenerateRandomEmailString(1, 128);

            //fill in the required fields and click register
            driver.FindElement(By.Id("firstname")).SendKeys(firstName);
            driver.FindElement(By.Id("lastname")).SendKeys(lastName);
            driver.FindElement(By.Id("email_address")).SendKeys(email);
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
}
