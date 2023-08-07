using FluentAssertions;
using MsTests.Helpers;

namespace MsTests.Tests
{

    [TestClass]
    public class SearchTests : BaseTest
    {
        [TestMethod]
        public void SearchResultsAreDisplayed()
        {
            Pages.HomePage.PerformSearchForKeyword("red");
            Pages.SearchResultsPage.IsKeywordResultsMessageDisplayed().Should().BeTrue();
        }
    }
}
