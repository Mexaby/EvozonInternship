using MsTests.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class LoginPage
    {
        #region Selectors

        private readonly By _emailField = By.Id("email");
        private readonly By _passwordField = By.Id("pass");
        private readonly By _loginButton = By.Id("send2");
        private readonly By _errorMessage = By.CssSelector(".error-msg");
        private readonly By _validationAdviceMessage = By.CssSelector(".validation-advice");

        #endregion

        public void Login(string email, string password)
        {
            _emailField.ActionSendKeys(email);
            _passwordField.ActionSendKeys(password);
            _loginButton.ActionClick();
        }

        public bool IsErrorMessageDisplayed()
        {
            return _errorMessage.IsElementPresent();
        }

        public bool IsValidationAdviceDisplayed()
        {
            return _validationAdviceMessage.IsElementPresent();
        }

    }
}
