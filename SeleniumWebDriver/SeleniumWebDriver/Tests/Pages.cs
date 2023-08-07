using MsTests.Helpers;
using MsTests.Pages;
using SeleniumExtras.PageObjects;

namespace MsTests.Tests
{
    public static class Pages
    {
        public static HomePage HomePage => InitPage(new HomePage());
        public static SubcategoryProductsPage SubcategoryProductsPage => InitPage(new SubcategoryProductsPage());
        public static LoginPage LoginPage => InitPage(new LoginPage());
        public static RegisterPage RegisterPage => InitPage(new RegisterPage());
        public static CategoryPage CategoryPage => InitPage(new CategoryPage());
        public static ConfigurableItemDetailsPage ConfigurableItemDetailsPage => InitPage(new ConfigurableItemDetailsPage());
        public static AdminPage AdminPage => InitPage(new AdminPage());
        public static WishlistPage WishlistPage => InitPage(new WishlistPage());
        public static CartPage CartPage => InitPage(new CartPage());
        public static AccountPage AccountPage => InitPage(new AccountPage());

        public static SearchResultsPage SearchResultsPage => InitPage(new SearchResultsPage());

        public static T InitPage<T>(T page)
        {
            PageFactory.InitElements(Driver.WebDriver, page);
            return page;
        }
    }
}
