using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MsTests.Helpers;
using MsTests.Pages;
using SeleniumExtras.PageObjects;

namespace MsTests.Tests
{
    public static class Pages
    {
        public static HomePage HomePage => InitPage(new HomePage());
        public static WomenCategoryPage WomenCategoryPage => InitPage(new WomenCategoryPage());
        public static LoginPage LoginPage => InitPage(new LoginPage());
        public static RegisterPage RegisterPage => InitPage(new RegisterPage());
        public static SubCategoryPage SubCategoryPage => InitPage(new SubCategoryPage());
        public static ConfigurableItemDetailsPage ConfigurableItemDetailsPage => InitPage(new ConfigurableItemDetailsPage());
        public static AdminPage AdminPage => InitPage(new AdminPage());
        public static WishlistPage WishlistPage => InitPage(new WishlistPage());

        public static SearchResultsPage SearchResultsPage => InitPage(new SearchResultsPage());

        public static T InitPage<T>(T page)
        {
            PageFactory.InitElements(Driver.WebDriver, page);
            return page;
        }
    }
}
