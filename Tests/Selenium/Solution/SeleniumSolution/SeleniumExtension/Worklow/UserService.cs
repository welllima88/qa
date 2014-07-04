using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.QA.Selenium.Extension.TestObjects.User;

namespace Six.Scs.QA.Selenium.Extension.Worklow
{
    public static class UserService
    {
        public static void Create(UserData u)
        {
            CustomerMenu.Users.Click();
            UserList.UserCreate.Click();

            UserCreate.UserName = u.UserName;
            UserCreate.Salutation = u.Salutation;
            UserCreate.FirstName = u.FirstName;
            UserCreate.Name = u.Name;
            UserCreate.Language = u.Language;
            UserCreate.Email = u.Email;
            UserCreate.SecurId = u.SecurId;
            UserCreate.Comment = u.Comment;
            UserCreate.WesMandant = u.WesMandant;

            UserCreate.SaveButton.Click();
            u.Password = UserView.Password;
            // Refresh for check due to inconsistent user interface ("de" vs "Deutsch [de]")
            UserMenu.User.Click();
        }

        public static void Check(UserData u)
        {
            Assert.AreEqual(u.UserName, UserView.UserName);
            StringAssert.IsMatch(TestRegExpPatterns.UserPassword, UserView.Password);
            Assert.AreEqual(u.Salutation, UserView.Salutation);
            Assert.AreEqual(u.FirstName, UserView.FirstName);
            Assert.AreEqual(u.Name, UserView.Name);
            Assert.AreEqual(u.Language, UserView.Language);
            Assert.AreEqual(u.Email, UserView.Email);
            Assert.AreEqual(u.SecurId, UserView.SecurId);
            Assert.AreEqual(u.Comment, UserView.Comment);
            Assert.AreEqual(u.WesMandant, UserView.WesMandant);
        }
    }
}