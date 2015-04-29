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
        public static Test.Model.ValueObjects.User Create(Test.Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            Test.Model.ValueObjects.User user = Test.Model.Factory.User.Create();
            Test.Workflow.User.Create(user);

            Check(user);
            Lobby.OpenLatestElement();
            Check(user);
            return user;
        }

        public static Test.Model.ValueObjects.User Edit(Test.Model.ValueObjects.User user)
        {
            Open(user);

            Test.Model.ValueObjects.User _user = Test.Model.Factory.User.Create();
            _user.UserName = user.UserName;
            _user.Password = user.Password; // copy password from creation

            Test.Workflow.User.Edit(_user);
            Check(_user);
            Lobby.OpenLatestElement();
            Check(_user);

            return _user;
        }

        public static void Open(Test.Model.ValueObjects.User user)
        {
            Search.UserCanBeFoundByCustomerName(user.UserName);
        }

        public static void Check(Test.Model.ValueObjects.User u)
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

            Test.View.Person.View.CreateUser.Click();

            StringAssert.Contains(person.Name, Test.View.User.Create.Name);
            StringAssert.Contains(person.FirstName, Test.View.User.Create.FirstName);
            StringAssert.Contains(person.Contact.Language, Test.View.User.Create.Language);
        }

        public static void AddService(Test.Model.ValueObjects.User user)
        {
            Open(user);
            IEnumerable<Service> services = Services.Scs();
            Test.Workflow.User.AddServices(services);
            IEnumerable<Service> actList = LoginSetup.GetAssignedServices();
            CollectionAssert.AreEquivalent(services, actList);
        }

        public static void AssignRoles(Test.Model.ValueObjects.User user)
        {
            Open(user);
            IEnumerable<string> roles =
                new Collection<string>(new[] {"Techsupport", "Kundendienst", "Terminal aufschalten +Intern", "PRIMAS"});

            Test.Workflow.User.AssignRoles(roles);

            IEnumerable<string> actList = Roles.GetAssignedRoles();
            CollectionAssert.AreEquivalent(roles, actList);
        }

        public static void Delete(Test.Model.ValueObjects.User user)
        {
            Open(user);
            Test.Workflow.User.Delete();
            Test.Workflow.Search.Find(user.UserName);
            Assert.That(new SearchResult(Result.User).Result(), Is.Not.Null);
            Assert.That(new SearchResult(Result.User).Result(), Is.Empty);
        }
    }
}