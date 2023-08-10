using FluentAssertions;
using MsTests.Helpers;
using MsTests.Helpers.Enums;

namespace MsTests.Tests
{
    [TestClass]
    public class CartTest : BaseTest
    {
        [TestMethod]
        public void AddtoCartConfigurableProductTest()
        {
            Pages.HeaderPage.NavigateToSubcategoryFromDropdown(Category.MEN, Subcategory.Men.TEES_KNITS_AND_POLOS);

            Pages.ProductsPage.GoToProductDetailsPage(Constants.CONFIGURABLE_PRODUCT);

            Pages.ProductDetailsPage.SelectItemColor(Color.Black);
            Pages.ProductDetailsPage.SelectItemSize(ClothesSize.M);
            Pages.ProductDetailsPage.ChangeQuantity(2);
            Pages.ProductDetailsPage.AddProductToCart();

            Pages.CartPage.GetConfirmationMessage().Should().Contain(Constants.CONFIGURABLE_PRODUCT);
            Pages.CartPage.IsProductInCart(Constants.CONFIGURABLE_PRODUCT).Should().BeTrue();
        }

        [TestMethod]
        public void AddtoCartDigitalProductTest()
        {
            Pages.HeaderPage.NavigateToSubcategoryFromDropdown(Category.HOME_AND_DECOR, Subcategory.HomeAndDecor.BOOKS_AND_MUSIC);

            Pages.ProductsPage.GoToProductDetailsPage(Constants.DIGITAL_PRODUCT);

            Pages.ProductDetailsPage.ChangeQuantity(3);
            Pages.ProductDetailsPage.CheckDigitalProduct();
            Pages.ProductDetailsPage.AddProductToCart();

            Pages.CartPage.GetConfirmationMessage().Should().Contain(Constants.DIGITAL_PRODUCT);
            Pages.CartPage.IsProductInCart(Constants.DIGITAL_PRODUCT).Should().BeTrue();

        }

        [TestMethod]
        public void AddtoCartSimpleProductTest()
        {
            Pages.HeaderPage.NavigateToSubcategoryFromDropdown(Category.VIP, null);

            Pages.ProductsPage.GoToProductDetailsPage(Constants.SIMPLE_PRODUCT);

            Pages.ProductDetailsPage.ChangeQuantity(4);
            Pages.ProductDetailsPage.AddProductToCart();

            Pages.CartPage.GetConfirmationMessage().Should().Contain(Constants.SIMPLE_PRODUCT);
            Pages.CartPage.IsProductInCart(Constants.SIMPLE_PRODUCT).Should().BeTrue();
        }

        [TestCleanup]
        public void After()
        {
            Pages.CartPage.EmptyCart();
        }
    }
}
