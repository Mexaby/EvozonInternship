using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsTests.Helpers;
using MsTests.Tests;

namespace MsTests.Tests
{
    [TestClass]
    public class CategoryNavigationTests : BaseTest
    {
        [TestMethod]
        public void NavigateMainCategories()
        {
            Pages.HomePage.NavigateToWomenCategories();
            Pages.HomePage.NavigateToMenCategory();
            Pages.HomePage.NavigateToAccessoriesCategory();
            Pages.HomePage.NavigateToHomeAndDecorCategory();
            Pages.HomePage.NavigateToSaleCategory();
            Pages.HomePage.NavigateToVipCategory();
            Pages.HomePage.NavigateToHomePage();
        }
    }
}
