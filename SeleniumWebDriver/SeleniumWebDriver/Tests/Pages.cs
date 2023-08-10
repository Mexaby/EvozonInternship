﻿using Automation.Pages;
using MsTests.Helpers;
using MsTests.Pages;
using NsTestFrameworkUI.Pages;
using SeleniumExtras.PageObjects;

namespace MsTests.Tests
{
    public static class Pages
    {
        public static HeaderPage HeaderPage => PageHelpers.InitPage(new HeaderPage());
        public static SubcategoryProductsPage SubcategoryProductsPage => PageHelpers.InitPage(new SubcategoryProductsPage());
        public static LoginPage LoginPage => PageHelpers.InitPage(new LoginPage());
        public static RegisterPage RegisterPage => PageHelpers.InitPage(new RegisterPage());
        public static ConfigurableItemDetailsPage ConfigurableItemDetailsPage => PageHelpers.InitPage(new ConfigurableItemDetailsPage());
        public static AdminPage AdminPage => PageHelpers.InitPage(new AdminPage());
        public static WishlistPage WishlistPage => PageHelpers.InitPage(new WishlistPage());
        public static CartPage CartPage => PageHelpers.InitPage(new CartPage());
        public static AccountPage AccountPage => PageHelpers.InitPage(new AccountPage());
        public static SearchResultsPage SearchResultsPage => PageHelpers.InitPage(new SearchResultsPage());
        public static ProductsPage ProductsPage => PageHelpers.InitPage(new ProductsPage());
        public static ProductDetailsPage ProductDetailsPage => PageHelpers.InitPage(new ProductDetailsPage());
    }
}
