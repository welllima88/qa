using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.Model.ValueObjects;
using Six.Scs.Test.View.Search;
using Six.Scs.Test.View.User;
using Six.Scs.Test.Workflow;
using Person = Six.Scs.Test.Model.ValueObjects.Person;

namespace Six.Scs.Test
{
    public class User
    {
        public static Model.ValueObjects.User Create(Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            var user = Model.Factory.User.Create();
            Workflow.User.Create(user);

            Check(user);
            Lobby.OpenLatestElement();
            Check(user);
            return user;
        }

        public static Model.ValueObjects.User Edit(Model.ValueObjects.User user)
        {
            Open(user);

            var _user = Model.Factory.User.Create();
            _user.UserName = user.UserName;
            _user.Password = user.Password; // copy password from creation

            Workflow.User.Edit(_user);
            Check(_user);
            Lobby.OpenLatestElement();
            Check(_user);

            return _user;
        }

        public static void Open(Model.ValueObjects.User user)
        {
            Search.UserCanBeFoundByCustomerName(user.UserName);
        }

        public static void Check(Model.ValueObjects.User u)
        {
            Assert.AreEqual(u.UserName, View.User.View.UserName);
            // StringAssert.IsMatch(TestRegExpPatterns.UserPassword, View.Password);
            Assert.AreEqual(u.Salutation, View.User.View.Salutation);
            Assert.AreEqual(u.FirstName, View.User.View.FirstName);
            Assert.AreEqual(u.Name, View.User.View.Name);
            Assert.AreEqual(u.Language, View.User.View.Language);
            Assert.AreEqual(u.Email, View.User.View.Email);
            Assert.AreEqual(u.SecurId, View.User.View.SecurId);
            Assert.AreEqual(u.Comment, View.User.View.Comment);
            StringAssert.Contains(u.WesMandant, View.User.View.WesMandant);
        }

        public static void Create(Person person)
        {
            Contact.Open(person);

            View.Person.View.CreateUser.Click();

            StringAssert.Contains(person.Name, View.User.Create.Name);
            StringAssert.Contains(person.FirstName, View.User.Create.FirstName);
            StringAssert.Contains(person.Contact.Language, View.User.Create.Language);
        }

        public static void AddService(Model.ValueObjects.User user)
        {
            Open(user);
            IEnumerable<Service> services = Services.Scs();
            Workflow.User.AddServices(services);
            IEnumerable<Service> actList = LoginSetup.GetAssignedServices();
            CollectionAssert.AreEquivalent(services, actList);
        }

        public static void AssignRoles(Model.ValueObjects.User user)
        {
            Open(user);
            IEnumerable<string> roles =
                new Collection<string>(new[] {"Techsupport", "Kundendienst", "Terminal aufschalten +Intern", "PRIMAS"});

            Workflow.User.AssignRoles(roles);

            var actList = Roles.GetAssignedRoles();
            CollectionAssert.AreEquivalent(roles, actList);
        }

        public static void Delete(Model.ValueObjects.User user)
        {
            Open(user);
            Workflow.User.Delete();
            Workflow.Search.Find(user.UserName);
            Assert.That(SearchResult.Result(Result.User), Is.Not.Null);
            Assert.That(SearchResult.Result(Result.User), Is.Empty);
        }
    }
}