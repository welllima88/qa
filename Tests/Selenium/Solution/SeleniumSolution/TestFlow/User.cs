using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Model.Factory;
using Six.Scs.QA.Selenium.Model.ValueObjects;
using Six.Scs.QA.Selenium.View.Search;
using Six.Scs.QA.Selenium.View.User;
using Six.Scs.QA.Selenium.Workflow;
using Person = Six.Scs.QA.Selenium.Model.ValueObjects.Person;

namespace Six.Scs.QA.Testlogic
{
    public class User
    {
        public static Selenium.Model.ValueObjects.User Create(Selenium.Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            Selenium.Model.ValueObjects.User user = Selenium.Model.Factory.User.Create();
            Selenium.Workflow.User.Create(user);

            Check(user);
            Lobby.OpenLatestElement();
            Check(user);
            return user;
        }

        public static Selenium.Model.ValueObjects.User Edit(Selenium.Model.ValueObjects.User user)
        {
            Open(user);

            Selenium.Model.ValueObjects.User _user = Selenium.Model.Factory.User.Create();
            _user.UserName = user.UserName;
            _user.Password = user.Password; // copy password from creation

            Selenium.Workflow.User.Edit(_user);
            Check(_user);
            Lobby.OpenLatestElement();
            Check(_user);

            return _user;
        }

        public static void Open(Selenium.Model.ValueObjects.User user)
        {
            Search.UserCanBeFoundByCustomerName(user.UserName);
        }

        public static void Check(Selenium.Model.ValueObjects.User u)
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

            Selenium.View.Person.View.CreateUser.Click();

            StringAssert.Contains(person.Name, Selenium.View.User.Create.Name);
            StringAssert.Contains(person.FirstName, Selenium.View.User.Create.FirstName);
            StringAssert.Contains(person.Contact.Language, Selenium.View.User.Create.Language);
        }

        public static void AddService(Selenium.Model.ValueObjects.User user)
        {
            Open(user);
            IEnumerable<Service> services = Services.Scs();
            Selenium.Workflow.User.AddServices(services);
            IEnumerable<Service> actList = LoginSetup.GetAssignedServices();
            CollectionAssert.AreEquivalent(services, actList);
        }

        public static void AssignRoles(Selenium.Model.ValueObjects.User user)
        {
            Open(user);
            IEnumerable<string> roles =
                new Collection<string>(new[] {"Techsupport", "Kundendienst", "Terminal aufschalten +Intern", "PRIMAS"});

            Selenium.Workflow.User.AssignRoles(roles);

            IEnumerable<string> actList = Roles.GetAssignedRoles();
            CollectionAssert.AreEquivalent(roles, actList);
        }

        public static void Delete(Selenium.Model.ValueObjects.User user)
        {
            Open(user);
            Selenium.Workflow.User.Delete();
            Selenium.Workflow.Search.Find(user.UserName);
            Assert.That(new SearchResult(Result.User).Result(), Is.Not.Null);
            Assert.That(new SearchResult(Result.User).Result(), Is.Empty);
        }
    }
}