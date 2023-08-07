using FluentAssertions;
using MsTests.Helpers;

namespace MsTests.Tests
{
    [TestClass]
    public class WishlistWithLoginTests : BaseTest
    {
        [TestInitialize]
        public override void Before()
        {
            base.Before();

            Pages.HomePage.NavigateToLogin();
            Pages.LoginPage.PerformLogin(Constants.validEmail, Constants.validPassword);

            Pages.HomePage.NavigateToCategory(0);
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
            Driver.WebDriver.SwitchTo().Alert().Accept();

            //confirmation
            Pages.WishlistPage.IsEmptyWishlistMessageDisplayed().Should().BeTrue();
        }

        
    }
}
