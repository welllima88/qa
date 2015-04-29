using System.Collections.Generic;
using Six.Scs.Test.Model.ValueObjects;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.User;

namespace Six.Scs.Test.Workflow
{
    public static class User
    {
        public static void Create(Model.ValueObjects.User u)
        {
            CustomerMenu.Users.Click();
            List.UserCreate.Click();

            View.User.Create.UserName = u.UserName;
            View.User.Create.Salutation = u.Salutation;
            View.User.Create.FirstName = u.FirstName;
            View.User.Create.Name = u.Name;
            View.User.Create.Language = u.Language;
            View.User.Create.Email = u.Email;
            View.User.Create.SecurId = u.SecurId;
            View.User.Create.Comment = u.Comment;
            View.User.Create.WesMandant = u.WesMandant;

            View.User.Create.SaveButton.Click();
            u.Password = View.User.View.Password;
            // Refresh for check due to inconsistent user interface ("de" vs "Deutsch [de]")
            UserMenu.User.Click();
        }

        public static void Edit(Model.ValueObjects.User u)
        {
            View.User.View.Edit.Click();

            View.User.Create.Salutation = u.Salutation;
            View.User.Create.FirstName = u.FirstName;
            View.User.Create.Name = u.Name;
            View.User.Create.Language = u.Language;
            View.User.Create.Email = u.Email;
            View.User.Create.SecurId = u.SecurId;
            View.User.Create.Comment = u.Comment;
            View.User.Create.WesMandant = u.WesMandant;

            View.User.Create.SaveButton.Click();
        }

        public static string ResetPassword()
        {
            UserMenu.ResetPassword.Click();
            View.User.View.ResetPasswordConfirm.Click();
            return View.User.View.Password;
        }

        public static void AddServices(IEnumerable<Service> services)
        {
            View.User.View.AddServiceButton.Click();

            foreach (Service service in services)
            {
                LoginSetup.Set(service.Name, service.Permission);
            }

            LoginSetup.SaveButton.Click();
        }

        public static void AssignRoles(IEnumerable<string> roles)
        {
            View.User.View.AssignRoles.Click();

            foreach (string role in roles)
            {
                Roles.Set(role);
            }
            Roles.Save();
        }

        public static void Delete()
        {
            View.User.View.DeleteButton.Click();
            View.User.Delete.ConfirmButton.Click();
        }
    }
}