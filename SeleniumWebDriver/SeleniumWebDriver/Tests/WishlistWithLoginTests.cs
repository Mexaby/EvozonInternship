using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using MsTests.Helpers;
using MsTests.Tests;

namespace MsTests.Tests
{
    [TestClass]
    public class WishlistWithLoginTests : BaseTest
    {
        [TestInitialize]
        public void Before()
        {
            new BaseTest().Before();

            Pages.HomePage.NavigateToLogin();
            Pages.LoginPage.PerformLogin("asdf@asdf.com", "111111");

            Pages.HomePage.NavigateToWomenCategories();
            Pages.WomenCategoryPage.NavigateToDressesAndSkirtsSubcategory();
            Pages.WomenCategoryPage.AddItemToWishlistFromCategoryPage(3);
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
