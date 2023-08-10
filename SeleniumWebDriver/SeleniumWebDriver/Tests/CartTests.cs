using FluentAssertions;
using MsTests.Helpers;
using MsTests.Helpers.Enums;

namespace MsTests.Tests
{
    [TestClass]
    public class CartTest : BaseTest
    {
        [TestMethod]
        public void AddConfigurableItemToCart()
        {
            //women > dresses and skirts
            Pages.HeaderPage.NavigateToSubcategoryFromDropdown(Category.WOMEN, Subcategory.Women.DRESSES_AND_SKIRTS);

            //second item from the products list
            Pages.SubcategoryProductsPage.ViewProductDetails(1);
            Pages.ConfigurableItemDetailsPage.SelectItemColor(Color.Purple);
            Pages.ConfigurableItemDetailsPage.SelectItemSize(ClothesSize.S);
            Pages.ConfigurableItemDetailsPage.AddItemToCart();

            //confirmation
            Pages.CartPage.IsSuccessMessageDisplayed().Should().BeTrue();
        }
    }
}
