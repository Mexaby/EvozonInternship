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

namespace NUnitTests.Tests
{
    [TestClass]
    public class CartTest : BaseTest
    {
        [TestMethod]
        public void AddConfigurableItemToCart()
        {
            //women > dresses and skirts
            Pages.HomePage.navigateToWomenCategories();
            Pages.WomenCategoryPage.navigateToDressesAndSkirtsSubcategory();

            Pages.SubCategoryPage.selectItemFromList(1);

            Pages.ConfigurableItemDetailsPage.selectItemColor(0);
            Pages.ConfigurableItemDetailsPage.selectItemSize(2);
            Pages.ConfigurableItemDetailsPage.addItemToCart();

            //confirmation
            Driver.WebDriver.FindElement(By.CssSelector(".success-msg span")).Text.Should()
                .Be("Racer Back Maxi Dress was added to your shopping cart.");
        }
    }
}
