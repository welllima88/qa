using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using Six.Scs.QA.Application.Model.Factory;
using Six.Scs.QA.Application.Model.ValueObjects;
using Six.Scs.QA.Application.View.Search;
using Six.Scs.QA.Application.View.User;
using Six.Scs.QA.Application.Workflow;
using Person = Six.Scs.QA.Application.Model.ValueObjects.Person;

namespace Six.Scs.QA.Testlogic
{
    public class User
    {
        public static Application.Model.ValueObjects.User Create(Application.Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            Application.Model.ValueObjects.User user = Application.Model.Factory.User.Create();
            Application.Workflow.User.Create(user);

            Check(user);
            Lobby.OpenLatestElement();
            Check(user);
            return user;
        }

        public static Application.Model.ValueObjects.User Edit(Application.Model.ValueObjects.User user)
        {
            Open(user);

            Application.Model.ValueObjects.User _user = Application.Model.Factory.User.Create();
            _user.UserName = user.UserName;
            _user.Password = user.Password; // copy password from creation

            Application.Workflow.User.Edit(_user);
            Check(_user);
            Lobby.OpenLatestElement();
            Check(_user);

            return _user;
        }

        public static void Open(Application.Model.ValueObjects.User user)
        {
            Search.UserCanBeFoundByCustomerName(user.UserName);
        }

        public static void Check(Application.Model.ValueObjects.User u)
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

            Application.View.Person.View.CreateUser.Click();

            StringAssert.Contains(person.Name, Application.View.User.Create.Name);
            StringAssert.Contains(person.FirstName, Application.View.User.Create.FirstName);
            StringAssert.Contains(person.Contact.Language, Application.View.User.Create.Language);
        }

        public static void AddService(Application.Model.ValueObjects.User user)
        {
            Open(user);
            IEnumerable<Service> services = Services.Scs();
            Application.Workflow.User.AddServices(services);
            IEnumerable<Service> actList = LoginSetup.GetAssignedServices();
            CollectionAssert.AreEquivalent(services, actList);
        }

        public static void AssignRoles(Application.Model.ValueObjects.User user)
        {
            Open(user);
            IEnumerable<string> roles =
                new Collection<string>(new[] {"Techsupport", "Kundendienst", "Terminal aufschalten +Intern", "PRIMAS"});

            Application.Workflow.User.AssignRoles(roles);

            IEnumerable<string> actList = Roles.GetAssignedRoles();
            CollectionAssert.AreEquivalent(roles, actList);
        }

        public static void Delete(Application.Model.ValueObjects.User user)
        {
            Open(user);
            Application.Workflow.User.Delete();
            Application.Workflow.Search.Find(user.UserName);
            Assert.That(new SearchResult(Result.User).Result(), Is.Not.Null);
            Assert.That(new SearchResult(Result.User).Result(), Is.Empty);
        }
    }
}