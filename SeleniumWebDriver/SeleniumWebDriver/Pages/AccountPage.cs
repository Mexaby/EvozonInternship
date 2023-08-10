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

        public string GetWelcomeMessage()
        {
            return _welcomeMessage.GetText();
        }
    }
}
