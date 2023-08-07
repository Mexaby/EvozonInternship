using MsTests.Helpers;
using NsTestFrameworkUI.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class ConfigurableItemDetailsPage
    {
        #region Selectors

        private readonly By _itemColorList = By.CssSelector("#configurable_swatch_color .swatch-label");
        private readonly By _itemSizeList = By.CssSelector("#configurable_swatch_size .swatch-label");
        private readonly By _addToCart = By.CssSelector(".add-to-cart-buttons .button");

        #endregion

        public void SelectItemColor(Color color)
        {
            //string itemColor = _itemColorList.GetAttribute("alt");
            Browser.WebDriver.FindElement(By.CssSelector($"#configurable_swatch_color [title=\"{color}\"] .swatch-label")).Click();
        }

        public void SelectItemSize(ClothesSize size)
        {
            Browser.WebDriver.FindElement(By.CssSelector($"#configurable_swatch_size [title=\"{size}\"] .swatch-label")).Click();
        }

        public void AddItemToCart()
        {
            _addToCart.ActionClick();
        }
    }
}
