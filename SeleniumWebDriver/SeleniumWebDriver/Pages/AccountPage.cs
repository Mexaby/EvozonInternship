using MsTests.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class AccountPage
    {
        #region Selectors

        private readonly By _welcomeMessage = By.CssSelector(".hello");

        #endregion

        public bool IsWelcomeMessageDisplayed()
        {
            return _welcomeMessage.IsElementPresent();
        }
    }
}
