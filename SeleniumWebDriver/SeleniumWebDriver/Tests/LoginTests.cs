using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using FluentAssertions;
using MsTests.Helpers;
using MsTests.Tests;

namespace NUnitTests.Tests
{
    [TestClass]
    public class LoginTests : BaseTest
    {
        [TestInitialize]
        public void Before()
        {
            new BaseTest().Before();

            Pages.HomePage.navigateToLogin();
        }


        [TestMethod]
        public void UserIntroducedValidLoginCredentials()
        {

            Pages.LoginPage.performLogin("asdf@asdf.com", "111111");
            //confirmation
            Driver.WebDriver.FindElement(By.CssSelector(".hello")).Text.Should().Be("Hello, Andrew 123 Tate!");
        }

        [TestMethod]
        public void UserIntroducedTooLongPassword()
        {
            string password =
                StringFaker.Randomize(
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[{]};:'\",<.>/?");
            
            Pages.LoginPage.performLogin("asdf@asdf.com", password);

            Driver.WebDriver.FindElement(By.CssSelector(".error-msg span")).Text.Should().Be("Invalid login or password.");

        }
    }
}
