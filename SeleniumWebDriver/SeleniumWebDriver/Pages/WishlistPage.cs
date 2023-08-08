using MsTests.Helpers;
using NsTestFrameworkUI.Pages;
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
            _deleteButton.ActionClick();
        }

        public bool IsSuccessMessageDisplayed()
        {
            return _successMessage.IsElementPresent();
        }

        public bool IsEmptyWishlistMessageDisplayed()
        {
            return _emptyWishlistMessage.IsElementPresent();
        }
    }
}
