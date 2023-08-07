using MsTests.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class CategoryPage
    {
        #region Selectors

        private readonly By _subcategoriesList = By.CssSelector(".catblocks li a");
        private readonly By _categoryTitle = By.CssSelector(".category-title");

        #endregion

        public void NavigateToSubcategoryProductsPage(int index)
        {
            _subcategoriesList.GetElements()[index].Click();
        }

        public bool IsCategoryTitleDisplayed()
        {
            return _categoryTitle.IsElementPresent();
        }
    }
}
