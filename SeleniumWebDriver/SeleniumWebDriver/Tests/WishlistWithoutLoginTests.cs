using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using MsTests.Helpers;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace MsTests.Tests
{
    [TestClass]
    internal class WishlistWithoutLoginTests : BaseTest
    {
        [TestMethod]
        public void AddItemToWishlistWithoutLogin()
        {
            Pages.HomePage.navigateToWomenCategories();
            Pages.WomenCategoryPage.navigateToDressesAndSkirtsSubcategory();
            Pages.WomenCategoryPage.addItemToWishlist(3);

            Driver.WebDriver.FindElement(By.CssSelector(".page-title h1")).Text.Should().Be("LOGIN OR CREATE AN ACCOUNT");
        }
    }
}
