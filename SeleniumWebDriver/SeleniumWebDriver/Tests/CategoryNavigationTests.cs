using FluentAssertions;
using MsTests.Helpers;
using MsTests.Helpers.Enums;

namespace MsTests.Tests
{
    [TestClass]
    public class CategoryNavigationTests : BaseTest
    {
        [TestMethod]
        public void NavigateThroughMainCategories()
        {
            Pages.HomePage.NavigateToCategory(Category.WOMEN);
            Pages.CategoryPage.IsCategoryTitleDisplayed().Should().BeTrue();

            Pages.HomePage.NavigateToCategory(Category.MEN);
            Pages.CategoryPage.IsCategoryTitleDisplayed().Should().BeTrue();

            Pages.HomePage.NavigateToCategory(Category.ACCESSORIES);
            Pages.CategoryPage.IsCategoryTitleDisplayed().Should().BeTrue();

            Pages.HomePage.NavigateToCategory(Category.HOME_AND_DECOR);
            Pages.CategoryPage.IsCategoryTitleDisplayed().Should().BeTrue();

            Pages.HomePage.NavigateToCategory(Category.SALE);
            Pages.CategoryPage.IsCategoryTitleDisplayed().Should().BeTrue();

            Pages.HomePage.NavigateToCategory(Category.VIP);
            Pages.CategoryPage.IsCategoryTitleDisplayed().Should().BeTrue();

            Pages.HomePage.NavigateToHomePage();
        }
    }
}
