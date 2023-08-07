using MsTests.Helpers;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class SubcategoryProductsPage
    {
        #region Selectors

        private readonly By _addItemToWishlist = By.CssSelector(".link-wishlist");

        #endregion

        public void AddItemToWishlistFromSubategoryPage(int index)
        {
            Driver.WebDriver.FindElements(_addItemToWishlist)[index].Click();
        }
    }
}
