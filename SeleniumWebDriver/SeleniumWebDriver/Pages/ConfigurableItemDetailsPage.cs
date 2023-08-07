using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsTests.Helpers;
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

        public void SelectItemColor(int index)
        {
            Driver.WebDriver.FindElements(_itemColorList)[index].Click();
        }

        public void SelectItemSize(int index)
        {
            Driver.WebDriver.FindElements(_itemSizeList)[index].Click();
        }

        public void AddItemToCart()
        {
            Driver.WebDriver.FindElement(_addToCart).Click();
        }
    }
}
