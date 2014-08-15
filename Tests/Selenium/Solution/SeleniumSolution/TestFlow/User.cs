using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Person;
using Six.Scs.QA.Selenium.User;
using Six.Scs.QA.TestData.ValueObjects;
using View = Six.Scs.QA.Selenium.User.View;

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
            StringAssert.IsMatch(TestRegExpPatterns.UserPassword, View.Password);
            Assert.AreEqual(u.Salutation, View.Salutation);
            Assert.AreEqual(u.FirstName, View.FirstName);
            Assert.AreEqual(u.Name, View.Name);
            Assert.AreEqual(u.Language, View.Language);
            Assert.AreEqual(u.Email, View.Email);
            Assert.AreEqual(u.SecurId, View.SecurId);
            Assert.AreEqual(u.Comment, View.Comment);
            Assert.AreEqual(u.WesMandant, View.WesMandant);
        }

        public static void Create(Person person)
        {
            Contact.Open(person);

            Selenium.Person.View.CreateUser.Click();
            
            Assert.Equals(person.Name, Selenium.User.Create.Name);
            Assert.Equals(person.FirstName, Selenium.User.Create.FirstName);
            Assert.Equals(person.Contact.Language, Selenium.User.Create.Language);
        }
    }
}