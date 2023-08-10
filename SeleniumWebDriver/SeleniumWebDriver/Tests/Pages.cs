using Automation.Pages;
using MsTests.Pages;
using NsTestFrameworkUI.Pages;

namespace MsTests.Tests
{
    public static class Pages
    {
        public static HeaderPage HeaderPage => PageHelpers.InitPage(new HeaderPage());
        public static LoginPage LoginPage => PageHelpers.InitPage(new LoginPage());
        public static RegisterPage RegisterPage => PageHelpers.InitPage(new RegisterPage());
        public static AdminPage AdminPage => PageHelpers.InitPage(new AdminPage());
        public static WishlistPage WishlistPage => PageHelpers.InitPage(new WishlistPage());
        public static CartPage CartPage => PageHelpers.InitPage(new CartPage());
        public static AccountPage AccountPage => PageHelpers.InitPage(new AccountPage());
        public static SearchResultsPage SearchResultsPage => PageHelpers.InitPage(new SearchResultsPage());
        public static ProductsPage ProductsPage => PageHelpers.InitPage(new ProductsPage());
        public static ProductDetailsPage ProductDetailsPage => PageHelpers.InitPage(new ProductDetailsPage());
    }
}
