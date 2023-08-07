using FluentAssertions;
using MsTests.Helpers;

namespace MsTests.Tests
{
    [TestClass]
    public class CategoryNavigationTests : BaseTest
    {
        [TestMethod]
        public void NavigateThroughMainCategories()
        {
            for (int i = 0; i < 6; i++)
            {
                Pages.HomePage.NavigateToCategory(i);
                Pages.CategoryPage.IsCategoryTitleDisplayed().Should().BeTrue();
            }
            Pages.HomePage.NavigateToHomePage();
        }
    }
}
