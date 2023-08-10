using Automation.Helpers.Enums;
using Faker;
using FluentAssertions;
using MsTests.Helpers;
using NsTestFrameworkUI.Helpers;

namespace MsTests.Tests
{
    [TestClass]
    public class RegisterTests : BaseTest
    {
        private NewAccount _newAccount = new NewAccount();

        [TestMethod]
        public void UserIntroducedValidRegisterCredentials()
        {
            Pages.HeaderPage.NavigateToAccountDropdownOption(AccountOption.REGISTER);
            Pages.RegisterPage.Register(_newAccount);

            Pages.AccountPage.GetWelcomeMessage().Should().Contain(_newAccount.FirstName);
            Pages.AccountPage.GetWelcomeMessage().Should().Contain(_newAccount.MiddleName);
            Pages.AccountPage.GetWelcomeMessage().Should().Contain(_newAccount.LastName);

            Pages.RegisterPage.IsSuccessMessageDisplayed().Should().BeTrue();
            Pages.HeaderPage.IsAccountOptionAvailable(AccountOption.LOG_IN).Should().BeFalse();
            Pages.HeaderPage.IsAccountOptionAvailable(AccountOption.LOG_OUT).Should().BeTrue();
        }

        [TestCleanup]
        public override void After()
        {
            Pages.AdminPage.PerformAdminLogin();
            Pages.AdminPage.DeleteLastRegisteredCustomer();
            
            Browser.WebDriver.SwitchTo().Alert().Accept();

            base.After();
        }
    }
}
