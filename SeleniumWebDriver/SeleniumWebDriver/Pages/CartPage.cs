using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class CartPage
    {
        #region Selectors

        private readonly By _confirmMessage = By.CssSelector("li.success-msg span");
        private readonly By _productsList = By.CssSelector("h2[class] a");
        private readonly By _emptyCartButton = By.Id("empty_cart_button");

        #endregion

        public string GetConfirmationMessage()
        {
            return _confirmMessage.GetText();
        }

        public bool IsProductInCart(string product)
        {
            var cartElementsName = _productsList.GetElements();
            return cartElementsName.Any(i => i.Text.Equals(product.ToUpper()));
        }

        public void EmptyCart()
        {
            _emptyCartButton.ActionClick();
        }
    }
}
