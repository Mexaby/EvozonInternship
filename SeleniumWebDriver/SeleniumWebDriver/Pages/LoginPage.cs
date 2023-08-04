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

        #endregion

        public void performLogin(string email, string password)
        {
            Driver.WebDriver.FindElement(_usernameField).SendKeys(email);
            Driver.WebDriver.FindElement(_passwordField).SendKeys(password);
            Driver.WebDriver.FindElement(_loginButton).Click();
        }
    }
}
