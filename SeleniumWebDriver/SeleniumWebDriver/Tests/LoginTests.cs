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
            Pages.LoginPage.PerformLogin(Constants.validEmail, Constants.validPassword);
            Pages.AccountPage.IsWelcomeMessageDisplayed().Should().BeTrue();
        }

        [TestMethod]
        public void UserIntroducedTooLongPassword()
        {
            string password =
                StringFaker.Randomize(
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[{]};:'\",<.>/?");
            
            Pages.LoginPage.PerformLogin(Constants.validEmail, password);

            Pages.LoginPage.IsErrorMessageDisplayed().Should().BeTrue();
        }
    }
}
