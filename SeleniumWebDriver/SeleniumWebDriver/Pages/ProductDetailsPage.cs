using MsTests.Helpers;
using MsTests.Helpers.Enums;
using NsTestFrameworkUI.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace Automation.Pages
{
    public class ProductDetailsPage
    {
        #region Selectors

        private readonly By _productTitle = By.CssSelector("div.product-name h1");
        private readonly By _addToCartButton = By.CssSelector("button.button.btn-cart[onclick]");
        private readonly By _addToWishlistButton = By.CssSelector(".link-wishlist");
        private readonly By _digitalItemCheckbox = By.Id("links_20");
        private readonly By _quantityField = By.Id("qty");
        private readonly By _colorList = By.CssSelector("#configurable_swatch_color a");
        private readonly By _colorButtonList = By.CssSelector("#configurable_swatch_color .swatch-label");
        private readonly By _sizeList = By.CssSelector("#configurable_swatch_size a");
        
        #endregion

        public void ChangeQuantity(int amount)
        {
            _quantityField.ActionSendKeys(amount.ToString());
        }

        public void AddProductToCart()
        {
            _addToCartButton.ActionClick();
        }

        public void CheckDigitalProduct()
        {
            _digitalItemCheckbox.ActionClick();
        }

        public void SelectItemColor(Color color)
        {
            var selectedColor = _colorList.GetElements()
                .FirstOrDefault(c => c.GetAttribute("title").Equals(color));
            if (selectedColor == null)
            {
                new ArgumentException($"The color is not available for this product.");
            }

            _colorButtonList.GetElements()[_colorList.GetElements().IndexOf(selectedColor)].Click();
        }

        public void SelectItemSize(ClothesSize size)
        {
            var selectedSize = _sizeList.GetElements()
                .FirstOrDefault(s => s.GetAttribute("title").Equals(size));
            if (selectedSize == null)
            {
                new ArgumentException($"The size is not available for this product.");
            }
            selectedSize.Click();
        }

        public void AddProductToWishlist()
        {
            _addToWishlistButton.ActionClick();
        }

    }
}
