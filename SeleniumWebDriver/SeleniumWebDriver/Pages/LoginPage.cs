using MsTests.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class LoginPage
    {
        #region Selectors

        private readonly By _usernameField = By.Id("email");
        private readonly By _passwordField = By.Id("pass");
        private readonly By _loginButton = By.Id("send2");

        private readonly By _errorMessage = By.CssSelector(".error-msg span");
        private readonly By _pageTitle = By.CssSelector(".page-title h1");

        #endregion

        public void PerformLogin(string email, string password)
        {
            _usernameField.ActionSendKeys(email);
            _passwordField.ActionSendKeys(password);
            _loginButton.ActionClick();
        }

        public bool IsErrorMessageDisplayed()
        {
            return _errorMessage.IsElementPresent();
        }

        public bool IsPageTitleDisplayed()
        {
            return _pageTitle.IsElementPresent();
        }

    }
}
