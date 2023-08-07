using Faker;
using FluentAssertions;
using MsTests.Helpers;

namespace MsTests.Tests
{
    [TestClass]
    public class RegisterTests : BaseTest
    {
        [TestMethod]
        public void UserIntroducedValidRegisterCredentials()
        {
            Pages.HomePage.NavigateToRegister();
            NewAccount account = new NewAccount();

            account.FirstName = Name.First();
            account.MiddleName = Name.Middle();
            account.LastName = Name.Last();
            account.Password = StringFaker.Randomize("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[{]};:'\",<.>/?");
            account.Email = Internet.Email();

            Pages.RegisterPage.PerformRegister(account);

            //confirmation
            Pages.RegisterPage.IsSuccessMessageDisplayed().Should().BeTrue();
        }

        [TestCleanup]
        public override void After()
        {
            //delete the created user from admin
            Pages.AdminPage.PerformAdminLogin();
            Pages.AdminPage.DeleteLastRegisteredCustomer();
            
            Driver.WebDriver.SwitchTo().Alert().Accept();

            //confirmation
            Pages.AdminPage.IsMessageDisplayed().Should().BeTrue();

            base.After();
        }
    }
}
