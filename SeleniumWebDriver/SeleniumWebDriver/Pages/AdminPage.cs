using MsTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MsTests.Pages
{
    public class AdminPage
    {
        #region Selectors

        private readonly By _username = By.Id("username");
        private readonly By _password = By.Id("login");
        private readonly By _loginButton = By.CssSelector(".form-button");

        private readonly By _messagePopup = By.CssSelector(".message-popup-head a");
        private readonly By _customersCategory =  By.CssSelector("li:nth-child(4) a");
        private readonly By _manageCustomersSubCategory = By.CssSelector("li:nth-child(4) ul .level1 a");
        private readonly By _firstCustomerFromGrid = By.CssSelector(".grid tbody tr:nth-child(1)");
        private readonly By _deleteButton = By.CssSelector(".main-col-inner .content-header p button:nth-child(4) span span span");

        private readonly By _successMessage = By.CssSelector(".messages span");

        #endregion

        public void PerformAdminLogin()
        {
            Driver.WebDriver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com/admin");
            Driver.WebDriver.FindElement(_username).SendKeys("testuser");
            Driver.WebDriver.FindElement(_password).SendKeys("password123");
            Driver.WebDriver.FindElement(_loginButton).Click();
        }

        public void DeleteLastRegisteredCustomer()
        {
            Driver.WebDriver.FindElement(_messagePopup).Click();

            var action = new Actions(Driver.WebDriver);
            var accessoriesElement = Driver.WebDriver.FindElements(_customersCategory)[3];
            action.MoveToElement(accessoriesElement).Perform();

            Driver.WebDriver.FindElements(_manageCustomersSubCategory)[0].Click();
            Driver.WebDriver.FindElement(_firstCustomerFromGrid).Click();
            Driver.WebDriver.FindElements(_deleteButton)[0].Click();
        }

        public bool IsMessageDisplayed()
        {
            return Driver.WebDriver.FindElement(_successMessage).Displayed;
        }
    }
}
