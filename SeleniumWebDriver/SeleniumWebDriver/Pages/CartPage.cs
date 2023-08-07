﻿using MsTests.Helpers;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class CartPage
    {
        #region Selectors

        private readonly By _successMessage = By.CssSelector(".success-msg span");

        #endregion

        public bool IsSuccessMessageDisplayed()
        {
            return Driver.WebDriver.FindElement(_successMessage).Displayed;
        }
    }
}
