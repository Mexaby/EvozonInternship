using FluentAssertions;
using MsTests.Helpers;

namespace MsTests.Tests
{
    [TestClass]
    public class CartTest : BaseTest
    {
        [TestMethod]
        public void AddConfigurableItemToCart()
        {
            //women > dresses and skirts
            Pages.HomePage.NavigateToCategory(0);
            Pages.HomePage.NavigateToSubcategoryFromDropdown(0, 4);

            Pages.CategoryPage.NavigateToSubcategoryProductsPage(1);

            Pages.ConfigurableItemDetailsPage.SelectItemColor(Color.Purple);
            Pages.ConfigurableItemDetailsPage.SelectItemSize(ClothesSize.S);
            Pages.ConfigurableItemDetailsPage.AddItemToCart();

            //confirmation
            Pages.CartPage.IsSuccessMessageDisplayed().Should().BeTrue();
        }
    }
}
