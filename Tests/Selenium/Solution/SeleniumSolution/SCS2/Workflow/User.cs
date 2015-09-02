using System.Collections.Generic;
using Six.Scs.Test.Model;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.User;

namespace Six.Scs.Test.Workflow
{
    public static class User
    {
        public static void Create(Model.User u)
        {
            CustomerMenu.Users.Click();
            List.UserCreate.Click();

            UI.User.Create.UserName = u.UserName;
            UI.User.Create.Salutation = u.Salutation;
            UI.User.Create.FirstName = u.FirstName;
            UI.User.Create.Name = u.Name;
            UI.User.Create.Language = u.Language;
            UI.User.Create.Email = u.Email;
            UI.User.Create.SecurId = u.SecurId;
            UI.User.Create.Comment = u.Comment;
            UI.User.Create.WesMandant = u.WesMandant;

            UI.User.Create.SaveButton.Click();
            u.Password = View.Password;
            // Refresh for check due to inconsistent user interface ("de" vs "Deutsch [de]")
            UserMenu.User.Click();
        }

        public static void Edit(Model.User u)
        {
            View.Edit.Click();

            UI.User.Create.Salutation = u.Salutation;
            UI.User.Create.FirstName = u.FirstName;
            UI.User.Create.Name = u.Name;
            UI.User.Create.Language = u.Language;
            UI.User.Create.Email = u.Email;
            UI.User.Create.SecurId = u.SecurId;
            UI.User.Create.Comment = u.Comment;
            UI.User.Create.WesMandant = u.WesMandant;

            UI.User.Create.SaveButton.Click();
        }

        public static string ResetPassword()
        {
            UserMenu.ResetPassword.Click();
            View.ResetPasswordConfirm.Click();
            return View.Password;
        }

        public static void AddServices(IEnumerable<Service> services)
        {
            View.AddServiceButton.Click();

            foreach (var service in services)
            {
                LoginSetup.Set(service.Name, service.Permission);
            }

            LoginSetup.SaveButton.Click();
        }

        public static void AssignRoles(IEnumerable<string> roles)
        {
            View.AssignRoles.Click();

            foreach (var role in roles)
            {
                Roles.Set(role);
            }
            Roles.Save();
        }

        public static void Delete()
        {
            View.DeleteButton.Click();
            UI.User.Delete.ConfirmButton.Click();
        }
    }
}