using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.User;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow
{
    public static class User
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

        public static void Edit(UserData u)
        {
            UserView.EditButton.Click();

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
        }

        public static string ResetPassword()
        {
            UserMenu.ResetPassword.Click();
            UserView.ResetPasswordConfirm.Click();
            return UserView.Password;
        }
    }
}