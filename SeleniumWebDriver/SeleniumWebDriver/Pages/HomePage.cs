using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using MsTests.Helpers;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class HomePage
    {
        #region Selectors

        //home page logo button
        private readonly By _homePageLogoButton = By.CssSelector("#header .large");
        //women's main category
        private readonly By _womenCategory = By.CssSelector(".level0.nav-1 a");
        //men's main category
        private readonly By _menCategory = By.CssSelector(".level0.nav-2 a");
        //accessories main category
        private readonly By _accessoriesCategory = By.CssSelector(".level0.nav-3 a");
        //home & decor main category
        private readonly By _homeAndDecorCategory = By.CssSelector(".level0.nav-4 a");
        //access sale main category
        private readonly By _saleCategory = By.CssSelector(".level0.nav-5 a");
        //vip main category
        private readonly By _vipCategory = By.CssSelector(".level0.nav-6 a");

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

        public void navigateToWomenCategories()
        {
            Driver.WebDriver.FindElement(_womenCategory).Click();
        }

        public void navigateToMenCategory()
        {
            Driver.WebDriver.FindElement(_menCategory).Click();
        }

        public void navigateToAccessoriesCategory()
        {
            Driver.WebDriver.FindElement(_accessoriesCategory).Click();
        }

        public void navigateToHomeAndDecorCategory()
        {
            Driver.WebDriver.FindElement(_homeAndDecorCategory).Click();
        }

        public void navigateToSaleCategory()
        {
            Driver.WebDriver.FindElement(_saleCategory).Click();
        }

        public void navigateToVipCategory()
        {
            Driver.WebDriver.FindElement(_vipCategory).Click();
        }

        public void navigateToHomePage()
        {
            Driver.WebDriver.FindElement(_homePageLogoButton).Click();
        }

        public void navigateToLogin()
        {
            Driver.WebDriver.FindElement(_accountDropDown).Click();
            Driver.WebDriver.FindElement(_loginButton).Click();
        }

        public void navigateToRegister()
        {
            Driver.WebDriver.FindElement(_accountDropDown).Click();
            Driver.WebDriver.FindElement(_registerButton).Click();
        }

        public void performSearchForKeyword(string keyword)
        {
            Driver.WebDriver.FindElement(_searchField).SendKeys(keyword);
            Driver.WebDriver.FindElement(_searchButton).Click();
        }
    }


}
