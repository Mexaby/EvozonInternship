using MsTests.Helpers;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class WishlistPage
    {
        #region Selectors

        private readonly By _deleteButton = By.CssSelector(".btn-remove.btn-remove2");
        private readonly By _successMessage = By.CssSelector(".success-msg span");
        private readonly By _emptyWishlistMessage = By.CssSelector(".wishlist-empty");

        #endregion

        public void RemoveLastItemFromWishlist()
        {
            Driver.WebDriver.FindElement(_deleteButton).Click();
        }

        public bool IsSuccessMessageDisplayed()
        {
            return Driver.WebDriver.FindElement(_successMessage).Displayed;
        }

        public bool IsEmptyWishlistMessageDisplayed()
        {
            return Driver.WebDriver.FindElement(_emptyWishlistMessage).Displayed;
        }
    }
}
