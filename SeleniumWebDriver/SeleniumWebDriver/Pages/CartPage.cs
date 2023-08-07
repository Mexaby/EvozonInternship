using MsTests.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class CartPage
    {
        #region Selectors

        private readonly By _successMessage = By.CssSelector(".success-msg span");

        #endregion

        public bool IsSuccessMessageDisplayed()
        {
            return _successMessage.IsElementPresent();
        }
    }
}
