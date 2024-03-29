﻿using FluentAssertions;
using MsTests.Helpers;
using MsTests.Helpers.Enums;
using OpenQA.Selenium;

namespace MsTests.Tests
{
    [TestClass]
    public class WishlistWithoutLoginTests : BaseTest
    {
        [TestMethod]
        public void AddItemToWishlistWithoutLogin()
        {
            Pages.HomePage.NavigateToSubcategoryFromDropdown(Category.WOMEN, Subcategory.Women.DRESSES_AND_SKIRTS);
            Pages.SubcategoryProductsPage.AddItemToWishlistFromSubategoryPage(3);

            Pages.LoginPage.IsPageTitleDisplayed().Should().BeTrue();
        }
    }
}
