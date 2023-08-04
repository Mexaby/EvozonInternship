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
using MsTests.Helpers;
using MsTests.Tests;

namespace NUnitTests.Tests
{
    [TestClass]
    public class RegisterTests : BaseTest
    {
        [TestMethod]
        public void UserIntroducedValidRegisterCredentials()
        {
            Pages.HomePage.navigateToRegister();

            string firstName = Name.First();
            string lastName = Name.Last();
            string password = StringFaker.Randomize("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[{]};:'\",<.>/?");
            string email = Internet.Email();

            Pages.RegisterPage.performRegisterWithRequiredFields(firstName, lastName, email, password);

            //confirmation
            Pages.RegisterPage.IsMessageDisplayed().Should().BeTrue();
        }

        [TestCleanup]
        public void After()
        {
            //delete the created user from admin
            Pages.AdminPage.PerformAdminLogin();
            Pages.AdminPage.DeleteLastRegisteredCustomer();
            
            Driver.WebDriver.SwitchTo().Alert().Accept();

            //confirmation
            Pages.AdminPage.IsMessageDisplayed().Should().BeTrue();

            new BaseTest().After();
        }
    }
}
