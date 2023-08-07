using MsTests.Helpers;
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
            Driver.WebDriver.FindElements(_subcategoriesList)[index].Click();
        }

        public bool IsCategoryTitleDisplayed()
        {
            return Driver.WebDriver.FindElement(_categoryTitle).Displayed;
        }
    }
}
