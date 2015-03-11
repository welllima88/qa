using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using Six.Scs.QA.Selenium.User;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;
using Six.Scs.QA.Workflow;
using Person = Six.Scs.QA.TestData.ValueObjects.Person;

namespace Six.Scs.QA.Testlogic
{
    public class User
    {
        public static TestData.ValueObjects.User Create(TestData.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            TestData.ValueObjects.User user = TestData.Factory.User.Create();
            Workflow.User.Create(user);

            Check(user);
            Lobby.OpenLatestElement();
            Check(user);
            return user;
        }

        public static TestData.ValueObjects.User Edit(TestData.ValueObjects.User user)
        {
            Open(user);

            TestData.ValueObjects.User _user = TestData.Factory.User.Create();
            _user.UserName = user.UserName;
            _user.Password = user.Password; // copy password from creation

            Workflow.User.Edit(_user);
            Check(_user);
            Lobby.OpenLatestElement();
            Check(_user);

            return _user;
        }

        public static void Open(TestData.ValueObjects.User user)
        {
            Search.UserCanBeFoundByCustomerName(user.UserName);
        }

        public static void Check(TestData.ValueObjects.User u)
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

            Selenium.Person.View.CreateUser.Click();

            StringAssert.Contains(person.Name, Selenium.User.Create.Name);
            StringAssert.Contains(person.FirstName, Selenium.User.Create.FirstName);
            StringAssert.Contains(person.Contact.Language, Selenium.User.Create.Language);
        }

        public static void AddService(TestData.ValueObjects.User user)
        {
            Open(user);
            IEnumerable<Service> services = Services.Scs();
            Workflow.User.AddServices(services);
            IEnumerable<Service> actList = LoginSetup.GetAssignedServices();
            CollectionAssert.AreEquivalent(services, actList);
        }

        public static void AssignRoles(TestData.ValueObjects.User user)
        {
            Open(user);
            IEnumerable<string> roles =
                new Collection<string>(new[] {"Techsupport", "Kundendienst", "Terminal aufschalten +Intern", "PRIMAS"});

            Workflow.User.AssignRoles(roles);

            IEnumerable<string> actList = Roles.GetAssignedRoles();
            CollectionAssert.AreEquivalent(roles, actList);
        }
    }
}