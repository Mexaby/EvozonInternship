using FluentAssertions;
using MsTests.Helpers;
using MsTests.Helpers.Enums;
using NsTestFrameworkUI.Helpers;

namespace MsTests.Tests
{
    [TestClass]
    public class WishlistWithoutLoginTests : BaseTest
    {
        [TestMethod]
        public void AddItemToWishlistWithoutLogin()
        {
            Pages.HeaderPage.NavigateToSubcategoryFromDropdown(Category.WOMEN, Subcategory.Women.DRESSES_AND_SKIRTS);
            Pages.ProductsPage.AddProductToWishlist(Constants.WISHLIST_PRODUCT);

            Browser.WebDriver.Url.Should().Be("http://qa2magento.dev.evozon.com/customer/account/login/");
        }
    }
}
