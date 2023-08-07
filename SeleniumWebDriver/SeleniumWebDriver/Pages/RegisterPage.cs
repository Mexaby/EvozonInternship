using MsTests.Helpers;
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
            Driver.WebDriver.FindElement(_firstNameField).SendKeys(account.FirstName);
            Driver.WebDriver.FindElement(_middleNameField).SendKeys(account.MiddleName);
            Driver.WebDriver.FindElement(_lastNameField).SendKeys(account.LastName);
            Driver.WebDriver.FindElement(_emailField).SendKeys(account.Email);
            Driver.WebDriver.FindElement(_passwordField).SendKeys(account.Password);
            Driver.WebDriver.FindElement(_confirmPasswordField).SendKeys(account.Password);
            Driver.WebDriver.FindElement(_registerButton).Click();
        }

        public bool IsSuccessMessageDisplayed()
        {
            return Driver.WebDriver.FindElement(_successMessage).Displayed;
        }

    }
}
