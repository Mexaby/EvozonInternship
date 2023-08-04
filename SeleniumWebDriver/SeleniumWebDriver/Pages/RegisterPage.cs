using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using MsTests.Helpers;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class RegisterPage
    {
        #region Selectors

        private readonly By _firstNameField = By.Id("firstname"); 
        private readonly By _lastNameField = By.Id("lastname"); 
        private readonly By _emailField = By.Id("email_address"); 
        private readonly By _passwordField = By.Id("password"); 
        private readonly By _confirmPasswordField = By.Id("confirmation");
        private readonly By _registerButton = By.CssSelector(".buttons-set .button");

        private readonly By _successMessage = By.CssSelector(".success-msg span");

        #endregion

        public void performRegisterWithRequiredFields(string firstname, string lastname, string email, string password)
        {
            Driver.WebDriver.FindElement(_firstNameField).SendKeys(firstname);
            Driver.WebDriver.FindElement(_lastNameField).SendKeys(lastname);
            Driver.WebDriver.FindElement(_emailField).SendKeys(email);
            Driver.WebDriver.FindElement(_passwordField).SendKeys(password);
            Driver.WebDriver.FindElement(_confirmPasswordField).SendKeys(password);
            Driver.WebDriver.FindElement(_registerButton).Click();
        }

        public bool IsMessageDisplayed()
        {
            return Driver.WebDriver.FindElement(_successMessage).Displayed;
        }

    }
}
