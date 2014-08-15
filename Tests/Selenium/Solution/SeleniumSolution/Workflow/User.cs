using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.User;

namespace Six.Scs.QA.Workflow
{
    public static class User
    {
        public static void Create(TestData.ValueObjects.User u)
        {
            CustomerMenu.Users.Click();
            List.UserCreate.Click();

            Selenium.User.Create.UserName = u.UserName;
            Selenium.User.Create.Salutation = u.Salutation;
            Selenium.User.Create.FirstName = u.FirstName;
            Selenium.User.Create.Name = u.Name;
            Selenium.User.Create.Language = u.Language;
            Selenium.User.Create.Email = u.Email;
            Selenium.User.Create.SecurId = u.SecurId;
            Selenium.User.Create.Comment = u.Comment;
            Selenium.User.Create.WesMandant = u.WesMandant;

            Selenium.User.Create.SaveButton.Click();
            u.Password = View.Password;
            // Refresh for check due to inconsistent user interface ("de" vs "Deutsch [de]")
            UserMenu.User.Click();
        }

        public static void Edit(TestData.ValueObjects.User u)
        {
            View.EditButton.Click();

            Selenium.User.Create.UserName = u.UserName;
            Selenium.User.Create.Salutation = u.Salutation;
            Selenium.User.Create.FirstName = u.FirstName;
            Selenium.User.Create.Name = u.Name;
            Selenium.User.Create.Language = u.Language;
            Selenium.User.Create.Email = u.Email;
            Selenium.User.Create.SecurId = u.SecurId;
            Selenium.User.Create.Comment = u.Comment;
            Selenium.User.Create.WesMandant = u.WesMandant;

            Selenium.User.Create.SaveButton.Click();
        }

        public static string ResetPassword()
        {
            UserMenu.ResetPassword.Click();
            View.ResetPasswordConfirm.Click();
            return View.Password;
        }
    }
}