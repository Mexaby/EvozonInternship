using FluentAssertions;
using MsTests.Helpers;
using MsTests.Helpers.Enums;
using NsTestFrameworkUI.Helpers;

namespace MsTests.Tests
{
    [TestClass]
    public class WishlistWithLoginTests : BaseTest
    {
        [TestInitialize]
        public override void Before()
        {
            base.Before();

            Pages.HeaderPage.NavigateToLogin();
            Pages.LoginPage.PerformLogin(Constants.VALID_EMAIL, Constants.VALID_PASSWORD);

            Pages.HeaderPage.NavigateToCategory(Category.WOMEN);
            Pages.CategoryPage.NavigateToSubcategoryProductsPage(3);
            Pages.SubcategoryProductsPage.AddItemToWishlistFromSubategoryPage(3);
        }

        [TestMethod]
        public void AddAnyItemToWishlistFromCategory()
        {
            //confirmation
            Pages.WishlistPage.IsSuccessMessageDisplayed().Should().BeTrue();
        }

        [TestMethod]
        public void RemoveOnlyItemFromWishlist()
        {
            Pages.WishlistPage.RemoveLastItemFromWishlist();
            Browser.WebDriver.SwitchTo().Alert().Accept();

            //confirmation
            Pages.WishlistPage.IsEmptyWishlistMessageDisplayed().Should().BeTrue();
        }

        
    }
}
