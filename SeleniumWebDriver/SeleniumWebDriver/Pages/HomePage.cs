using MsTests.Helpers;
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
        private readonly By _searchField  = By.Id("search");
        //search button
        private readonly By _searchButton = By.CssSelector(".search-button");

        #endregion

        public void NavigateToCategory(int index)
        {
            Driver.WebDriver.FindElement(By.CssSelector($".level0.nav-{index+1} a")).Click();
        }

        public void NavigateToSubcategoryFromDropdown(int categoryIndex, int subcategoryIndex)
        {
            var categoryDropDownElement = Driver.WebDriver.FindElement(By.CssSelector($".level0.nav-{categoryIndex + 1} a"));
            Actions action = new Actions(Driver.WebDriver);
            action.MoveToElement(categoryDropDownElement).Perform();

            Driver.WebDriver.FindElements(_subcategoryList)[subcategoryIndex].Click();
        }
        
        public void NavigateToHomePage()
        {
            Driver.WebDriver.FindElement(_homePageLogoButton).Click();
        }

        public void NavigateToLogin()
        {
            Driver.WebDriver.FindElement(_accountDropDown).Click();
            Driver.WebDriver.FindElement(_loginButton).Click();
        }

        public void NavigateToRegister()
        {
            Driver.WebDriver.FindElement(_accountDropDown).Click();
            Driver.WebDriver.FindElement(_registerButton).Click();
        }

        public void PerformSearchForKeyword(string keyword)
        {
            Driver.WebDriver.FindElement(_searchField).SendKeys(keyword);
            Driver.WebDriver.FindElement(_searchButton).Click();
        }
    }


}
