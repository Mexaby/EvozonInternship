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
    public class CartTest : BaseTest
    {
        [TestMethod]
        public void AddConfigurableItemToCart()
        {
            //women > dresses and skirts
            Pages.HomePage.NavigateToWomenCategories();
            Pages.WomenCategoryPage.NavigateToDressesAndSkirtsSubcategory();

            Pages.SubCategoryPage.SelectItemFromList(1);

            Pages.ConfigurableItemDetailsPage.SelectItemColor(0);
            Pages.ConfigurableItemDetailsPage.SelectItemSize(2);
            Pages.ConfigurableItemDetailsPage.AddItemToCart();

            //confirmation
            Pages.CartPage.IsSuccessMessageDisplayed().Should().BeTrue();
        }
    }
}
