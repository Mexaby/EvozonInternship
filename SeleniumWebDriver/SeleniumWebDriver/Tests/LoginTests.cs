using Faker;
using FluentAssertions;
using MsTests.Helpers;

namespace MsTests.Tests
{
    [TestClass]
    public class LoginTests : BaseTest
    {
        [TestInitialize]
        public override void Before()
        {
            base.Before();

            Pages.HomePage.NavigateToLogin();
        }


        [TestMethod]
        public void UserIntroducedValidLoginCredentials()
        {
            Pages.LoginPage.PerformLogin(Constants.VALID_EMAIL, Constants.VALID_PASSWORD);
            Pages.AccountPage.IsWelcomeMessageDisplayed().Should().BeTrue();
        }

        [TestMethod]
        public void UserIntroducedTooLongPassword()
        {
            Pages.LoginPage.PerformLogin(Constants.VALID_EMAIL, Constants.RANDOM_PASSWORD);
            Pages.LoginPage.IsErrorMessageDisplayed().Should().BeTrue();
        }
    }
}
