using System;
using System.Collections.Generic;
using NUnit.Framework;
using Six.Scs.QA.Selenium.User;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;

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
            Workflow.Lobby.OpenLatestElement();
            Check(user);
            return user;
        }

        public static TestData.ValueObjects.User Edit(TestData.ValueObjects.User user)
        {
            throw new NotImplementedException();
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
            Assert.AreEqual(u.WesMandant, View.WesMandant);
        }

        public static void Create(TestData.ValueObjects.Person person)
        {
            Contact.Open(person);

            Selenium.Person.View.CreateUser.Click();

            Assert.Equals(person.Name, Selenium.User.Create.Name);
            Assert.Equals(person.FirstName, Selenium.User.Create.FirstName);
            Assert.Equals(person.Contact.Language, Selenium.User.Create.Language);
        }

        public static void AddService(TestData.ValueObjects.User user)
        {
            Open(user);
            IEnumerable<Service> services = Services.Scs();
            Workflow.User.AddServices(services);
            Check(services);
        }

        private static void Check(IEnumerable<Service> services)
        {
            foreach (var service in services)
            {
                // TODO ..
            }
        }
    }
}