using Faker;
using FluentAssertions;
using MsTests.Helpers;
using NsTestFrameworkUI.Helpers;

namespace MsTests.Tests
{
    [TestClass]
    public class RegisterTests : BaseTest
    {
        [TestMethod]
        public void UserIntroducedValidRegisterCredentials()
        {
            Pages.HomePage.NavigateToRegister();
            Pages.RegisterPage.PerformRegister(new NewAccount());

            //confirmation
            Pages.RegisterPage.IsSuccessMessageDisplayed().Should().BeTrue();
        }

        [TestCleanup]
        public override void After()
        {
            //delete the created user from admin
            Pages.AdminPage.PerformAdminLogin();
            Pages.AdminPage.DeleteLastRegisteredCustomer();
            
            Browser.WebDriver.SwitchTo().Alert().Accept();

            base.After();
        }
    }
}
