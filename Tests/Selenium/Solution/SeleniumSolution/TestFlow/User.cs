using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using Six.Scs.Test.Factory;
using Six.Scs.Test.Model;
using Six.Scs.Test.UI.Search;
using Six.Scs.Test.UI.User;
using Six.Scs.Test.Workflow;
using Person = Six.Scs.Test.Model.Person;

namespace Six.Scs.Test
{
    public class User
    {
        public static Model.User Create(Model.Customer customer)
        {
            Customer.Open(customer);
            var user = Factory.User.Create();
            Workflow.User.Create(user);

            Check(user);
            Lobby.OpenLatestElement();
            Check(user);
            return user;
        }

        public static Model.User Edit(Model.User user)
        {
            Open(user);

            var _user = Factory.User.Create();
            _user.UserName = user.UserName;
            _user.Password = user.Password; // copy password from creation

            Workflow.User.Edit(_user);
            Check(_user);
            Lobby.OpenLatestElement();
            Check(_user);

            return _user;
        }

        public static void Open(Model.User user)
        {
            Search.UserCanBeFoundByCustomerName(user.UserName);
        }

        public static void Check(Model.User u)
        {
            Assert.AreEqual(u.UserName, View.UserName);
            // StringAssert.IsMatch(TestRegExpPatterns.UserPassword, View.Password);
            Assert.AreEqual(u.Salutation, View.Salutation);
            Assert.AreEqual(u.FirstName, View.FirstName);
            Assert.AreEqual(u.Name, View.Name);
            Assert.AreEqual(u.Language, View.Language);
            Assert.AreEqual(u.Email, View.Email);
            Assert.AreEqual(u.SecurId, View.SecurId);
            Assert.AreEqual(u.Comment, View.Comment);
            StringAssert.Contains(u.WesMandant, View.WesMandant);
        }

        public static void Create(Person person)
        {
            Contact.Open(person);

            UI.Person.View.CreateUser.Click();

            StringAssert.Contains(person.Name, UI.User.Create.Name);
            StringAssert.Contains(person.FirstName, UI.User.Create.FirstName);
            StringAssert.Contains(person.Contact.Language, UI.User.Create.Language);
        }

        public static void AddService(Model.User user)
        {
            Open(user);
            IEnumerable<Service> services = Services.Scs();
            Workflow.User.AddServices(services);
            IEnumerable<Service> actList = LoginSetup.GetAssignedServices();
            CollectionAssert.AreEquivalent(services, actList);
        }

        public static void AssignRoles(Model.User user)
        {
            Open(user);
            IEnumerable<string> roles =
                new Collection<string>(new[]
                {"Tickets", "Kunde anzeigen", "Benutzer anzeigen", "SCS Administrator", "Verwaltung"});

            Workflow.User.AssignRoles(roles);

            var actList = Roles.GetAssignedRoles();
            Assert.That(actList, Is.EquivalentTo(roles));
        }

        public static void Delete(Model.User user)
        {
            Open(user);
            Workflow.User.Delete();
            Workflow.Search.Find(user.UserName);
            Assert.That(SearchResult.Result(Result.User), Is.Not.Null);
            Assert.That(SearchResult.Result(Result.User), Is.Empty);
        }
    }
}