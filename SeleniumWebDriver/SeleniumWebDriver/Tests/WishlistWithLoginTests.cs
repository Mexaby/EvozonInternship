﻿using Automation.Helpers.Enums;
using FluentAssertions;
using MsTests.Helpers;
using MsTests.Helpers.Enums;

namespace MsTests.Tests
{
    [TestClass]
    public class WishlistWithLoginTests : BaseTest
    {
        [TestInitialize]
        public override void Before()
        {
            base.Before();

            Pages.HeaderPage.NavigateToAccountDropdownOption(AccountOption.LOG_IN);
            Pages.LoginPage.Login(Constants.VALID_EMAIL, Constants.VALID_PASSWORD);
        }

        public static IEnumerable<object[]> WishlistData()
        {
            yield return new object[] { Category.VIP, null, "Broad St. Flapover Briefcase" };
            yield return new object[] { Category.WOMEN, Subcategory.Women.NEW_ARRIVALS, "Elizabeth Knit Top" };
            yield return new object[] { Category.MEN, Subcategory.Men.SHIRTS, "Plaid Cotton Shirt" };
            yield return new object[] { Category.ACCESSORIES, Subcategory.Accessories.SHOES, "Suede Loafer, Navy" };
            yield return new object[] { Category.HOME_AND_DECOR, Subcategory.HomeAndDecor.BOOKS_AND_MUSIC, "Alice in Wonderland" };
        }

        [DynamicData(nameof(WishlistData), DynamicDataSourceType.Method)]
        [TestMethod]
        public void AddProductToWishlistFromProductsPage(Category category, Enum subcategory, string productName)
        {
            Pages.HeaderPage.NavigateToSubcategoryFromDropdown(category, subcategory);
            Pages.ProductsPage.AddProductToWishlist(productName);

            Pages.WishlistPage.GetProductAddedToWishlistConfirmationMessage().Should().Contain(productName);
            Pages.WishlistPage.IsProductInWishlist(productName).Should().BeTrue();
        }

        [DynamicData(nameof(WishlistData), DynamicDataSourceType.Method)]
        [TestMethod]
        public void AddProductToWishlistFromProductDetailsPage(Category category, Enum subcategory, string productName)
        {
            Pages.HeaderPage.NavigateToSubcategoryFromDropdown(category, subcategory);
            Pages.ProductsPage.GoToProductDetailsPage(productName);
            Pages.ProductDetailsPage.AddProductToWishlist();

            Pages.WishlistPage.GetProductAddedToWishlistConfirmationMessage().Should().Contain(productName);
            Pages.WishlistPage.IsProductInWishlist(productName).Should().BeTrue();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Pages.WishlistPage.RemoveAllProductsFromWishlist();
            //Pages.WishlistPage.RemoveProductFromWishlist((string)TestContext.Properties["ProductName"]);
        }
    }
}
