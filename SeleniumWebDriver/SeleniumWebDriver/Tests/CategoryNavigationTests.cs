using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsTests.Helpers;
using MsTests.Tests;

namespace NUnitTests.Tests
{
    [TestClass]
    public class CategoryNavigationTests : BaseTest
    {
        [TestMethod]
        public void NavigateMainCategories()
        {
            Pages.HomePage.navigateToWomenCategories();
            Pages.HomePage.navigateToMenCategory();
            Pages.HomePage.navigateToAccessoriesCategory();
            Pages.HomePage.navigateToHomeAndDecorCategory();
            Pages.HomePage.navigateToSaleCategory();
            Pages.HomePage.navigateToVipCategory();
            Pages.HomePage.navigateToHomePage();
        }
    }
}
