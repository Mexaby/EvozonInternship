using MsTests.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class SearchResultsPage
    {
        #region Selectors

        private readonly By _keywordResultsMessage = By.CssSelector(".page-title h1");

        #endregion

        public bool IsKeywordResultsMessageDisplayed()
        {
            return _keywordResultsMessage.IsElementPresent();
        }
    }
}
