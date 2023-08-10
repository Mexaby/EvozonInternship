using NsTestFrameworkUI.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class WishlistPage
    {
        #region Selectors

        private readonly By _wishlistProductNames = By.CssSelector("#wishlist-table tbody tr h3 a");
        private readonly By _wishlistRemoveButtons = By.CssSelector("#wishlist-table tbody tr td[class*=\"remove\"] a");
        private readonly By _confirmationMessage = By.CssSelector("li.success-msg span");

        #endregion

        public string GetProductAddedToWishlistConfirmationMessage()
        {
            return _confirmationMessage.GetText();
        }

        public bool IsProductInWishlist(string product)
        {
            var wishlistElementsName = _wishlistProductNames.GetElements();
            return wishlistElementsName.Any(i => i.Text.Equals(product.ToUpper()));

        }
        
        public void RemoveAllProductsFromWishlist()
        {
            while (_wishlistRemoveButtons.GetElements().Count > 0)
            {
                _wishlistRemoveButtons.ActionClick();
                Browser.WebDriver.SwitchTo().Alert().Accept();
            }
        }
    }
}
