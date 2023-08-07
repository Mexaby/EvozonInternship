using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsTests.Helpers;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class SubCategoryPage
    {
        #region Selectors

        private readonly By _itemListSelector = By.CssSelector(".product-info .actions .button");

        #endregion

        public void SelectItemFromList(int index)
        {
            Driver.WebDriver.FindElements(_itemListSelector)[index].Click();
        }
    }
}
