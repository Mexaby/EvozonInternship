using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsTests.Helpers;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class LoginPage
    {
        #region Selectors

        private readonly By _usernameField = By.Id("email");
        private readonly By _passwordField = By.Id("pass");
        private readonly By _loginButton = By.Id("send2");

        private readonly By _welcomeMessage = By.CssSelector(".hello");
        private readonly By _errorMessage = By.CssSelector(".error-msg span");

        #endregion

        public void PerformLogin(string email, string password)
        {
            Driver.WebDriver.FindElement(_usernameField).SendKeys(email);
            Driver.WebDriver.FindElement(_passwordField).SendKeys(password);
            Driver.WebDriver.FindElement(_loginButton).Click();
        }

        public bool IsWelcomeMessageDisplayed()
        {
            return Driver.WebDriver.FindElement(_welcomeMessage).Displayed;
        }

        public bool IsErrorMessageDisplayed()
        {
            return Driver.WebDriver.FindElement(_errorMessage).Displayed;
        }

    }
}
