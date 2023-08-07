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

namespace MsTests.Tests
{
    [TestClass]
    public class LoginTests : BaseTest
    {
        [TestInitialize]
        public void Before()
        {
            new BaseTest().Before();

            Pages.HomePage.NavigateToLogin();
        }


        [TestMethod]
        public void UserIntroducedValidLoginCredentials()
        {
            Pages.LoginPage.PerformLogin("asdf@asdf.com", "111111");
            Pages.LoginPage.IsWelcomeMessageDisplayed().Should().BeTrue();
        }

        [TestMethod]
        public void UserIntroducedTooLongPassword()
        {
            string password =
                StringFaker.Randomize(
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[{]};:'\",<.>/?");
            
            Pages.LoginPage.PerformLogin("asdf@asdf.com", password);

            Pages.LoginPage.IsErrorMessageDisplayed().Should().BeTrue();
        }
    }
}
