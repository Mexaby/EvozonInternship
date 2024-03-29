﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Faker;
using FluentAssertions;

namespace NUnitTests.Tests
{
    [TestFixture]
    public class LoginTests
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

            string password =
                StringFaker.Randomize(
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[{]};:'\",<.>/?");
            driver.FindElement(By.Id("pass")).SendKeys(password);
            driver.FindElement(By.Id("send2")).Click();

            driver.FindElement(By.CssSelector(".error-msg span")).Text.Should().Be("Invalid login or password.");

            driver.Close();
        }
    }
}
