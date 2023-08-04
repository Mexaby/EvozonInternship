using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsTests.Helpers;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class SearchResultsPage
    {
        #region Selectors

        private readonly By _keywordResultsMessage = By.CssSelector(".page-title h1");

        #endregion

        public bool IsMessageDisplayed()
        {
            return Driver.WebDriver.FindElement(_keywordResultsMessage).Displayed;
        }
    }
}
