using MsTests.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class RegisterPage
    {
        #region Selectors

        private readonly By _firstNameField = By.Id("firstname"); 
        private readonly By _middleNameField = By.Id("middlename"); 
        private readonly By _lastNameField = By.Id("lastname"); 
        private readonly By _emailField = By.Id("email_address"); 
        private readonly By _passwordField = By.Id("password"); 
        private readonly By _confirmPasswordField = By.Id("confirmation");
        private readonly By _registerButton = By.CssSelector(".buttons-set .button");

        private readonly By _successMessage = By.CssSelector(".success-msg span");

        #endregion

        public void PerformRegister(NewAccount account)
        {
            _firstNameField.ActionSendKeys(account.FirstName);
            _middleNameField.ActionSendKeys(account.MiddleName);
            _lastNameField.ActionSendKeys(account.LastName);
            _emailField.ActionSendKeys(account.Email);
            _passwordField.ActionSendKeys(account.Password);
            _confirmPasswordField.ActionSendKeys(account.Password);
            _registerButton.ActionClick();
        }

        public bool IsSuccessMessageDisplayed()
        {
            return _successMessage.IsElementPresent();
        }

    }
}
