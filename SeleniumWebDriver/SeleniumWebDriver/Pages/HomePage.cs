
using MsTests.Helpers;
using MsTests.Helpers.Enums;
using NsTestFrameworkUI.Helpers;
using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MsTests.Pages
{
    public class HomePage
    {
        #region Selectors

        //home page logo button
        private readonly By _homePageLogoButton = By.CssSelector("#header .large");
        //subcategories list
        private readonly By _subcategoryList = By.CssSelector(".level1 a");
        //account dropdown
        private readonly By _accountDropDown = By.CssSelector(".account-cart-wrapper .skip-link.skip-account");
        //login button
        private readonly By _loginButton = By.CssSelector("#header-account .last a");
        //register button
        private readonly By _registerButton = By.CssSelector("#header-account .links :nth-child(5) a");
        //search field
        private readonly By _searchField = By.Id("search");
        //search button
        private readonly By _searchButton = By.CssSelector(".search-button");
        //category drop down buttons
        private readonly By _categoryButtonsList = By.CssSelector(".level0 > a, .level0.has-children > a");

        #endregion

        public void NavigateToCategory(Category categoryTitle)
        {
            // get all category elements
            var categories = _categoryButtonsList.GetElements();
            // find the category with the matching title
            string s = categoryTitle.GetDescription();
            var category = categories.FirstOrDefault(c => c.Text == categoryTitle.GetDescription());
            if (category == null)
            {
                throw new ArgumentException($"No category found with title: {categoryTitle}");
            }
            // click the category
            category.Click();
        }


        public void NavigateToSubcategoryFromDropdown(Category categoryTitle, Enum subcategoryTitle)
        {

            // get all category elements
            var categories = _categoryButtonsList.GetElements();
            // find the category with the matching title
            var category = categories.FirstOrDefault(c => c.Text == categoryTitle.GetDescription());
            if (category == null)
            {
                throw new ArgumentException($"No category found with title: {categoryTitle}");
            }
            // hover over the category
            category.Hover();

            var subcategories = _subcategoryList.GetElements();
            var subcategory = subcategories.FirstOrDefault(s => s.Text == subcategoryTitle.GetDescription());
            if (subcategory == null)
            {
                throw new ArgumentException($"No subcategory found with title: {categoryTitle}");
            }
            subcategory.Click();
        }

        public void NavigateToHomePage()
        {
            _homePageLogoButton.ActionClick();
        }

        public void NavigateToLogin()
        {
            _accountDropDown.ActionClick();
            _loginButton.ActionClick();
        }

        public void NavigateToRegister()
        {
            _accountDropDown.ActionClick();
            _registerButton.ActionClick();
        }

        public void PerformSearchForKeyword(string keyword)
        {
            _searchField.ActionSendKeys(keyword);
            _searchButton.ActionClick();
            WaitHelpers.WaitForDocumentReadyState();
        }
    }


}
