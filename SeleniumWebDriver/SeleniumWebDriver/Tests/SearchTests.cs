using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using MsTests.Helpers;
using MsTests.Tests;

namespace MsTests.Tests
{

    [TestClass]
    public class SearchTests : BaseTest
    {
        [TestMethod]
        public void SearchForKeyword()
        {
            Pages.HomePage.PerformSearchForKeyword("red");
            Pages.SearchResultsPage.IsMessageDisplayed().Should().BeTrue();
        }
    }
}
