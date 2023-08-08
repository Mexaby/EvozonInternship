using System.Reflection.PortableExecutable;
using MsTests.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class SubcategoryProductsPage
    {
        #region Selectors

        private readonly By _addItemToWishlist = By.CssSelector(".link-wishlist");
        private readonly By _viewProductDetails = By.CssSelector(".product-info .actions .button");

        #endregion

        public void AddItemToWishlistFromSubategoryPage(int index)
        {
            _addItemToWishlist.GetElements()[index].Click();
        }

        public void ViewProductDetails(int index)
        {
            _viewProductDetails.GetElements()[index].Click();
        }
    }
}
