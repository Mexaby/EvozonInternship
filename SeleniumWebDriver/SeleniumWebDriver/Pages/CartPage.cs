using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsTests.Helpers;
using OpenQA.Selenium;

namespace MsTests.Pages
{
    public class CartPage
    {
        #region Selectors

        private readonly By _successMessage = By.CssSelector(".success-msg span");

        #endregion

        public void findSuccessMessage()
        {
            Driver.WebDriver.FindElement(_successMessage);
        }
    }
}
