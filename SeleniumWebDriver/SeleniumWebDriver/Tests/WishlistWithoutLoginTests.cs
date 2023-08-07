using FluentAssertions;
using MsTests.Helpers;
using OpenQA.Selenium;

namespace MsTests.Tests
{
    [TestClass]
    internal class WishlistWithoutLoginTests : BaseTest
    {
        [TestMethod]
        public void AddItemToWishlistWithoutLogin()
        {
            Pages.HomePage.NavigateToCategory(0);
            Pages.HomePage.NavigateToSubcategoryFromDropdown(0, 4);
            Pages.SubcategoryProductsPage.AddItemToWishlistFromSubategoryPage(3);

            Driver.WebDriver.FindElement(By.CssSelector(".page-title h1")).Text.Should().Be("LOGIN OR CREATE AN ACCOUNT");
        }
    }
}
