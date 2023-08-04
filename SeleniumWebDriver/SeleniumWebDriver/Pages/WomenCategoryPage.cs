using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsTests.Helpers;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class WomenCategoryPage
    {
        #region Selectors

        private readonly By _dressessAndSkirts = By.CssSelector(".catblocks :nth-child(4) a");
        private readonly By _addItemToWishlist = By.CssSelector(".link-wishlist");

        #endregion

        public void navigateToDressesAndSkirtsSubcategory()
        {
            Driver.WebDriver.FindElement(_dressessAndSkirts).Click();
        }

        public void addItemToWishlist(int index)
        {
            Driver.WebDriver.FindElements(_addItemToWishlist)[index].Click();
        }
    }
}
