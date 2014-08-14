using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Person;
using Six.Scs.QA.Selenium.User;
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
            Assert.AreEqual(u.UserName, UserView.UserName);
            StringAssert.IsMatch(TestRegExpPatterns.UserPassword, UserView.Password);
            Assert.AreEqual(u.Salutation, UserView.Salutation);
            Assert.AreEqual(u.FirstName, UserView.FirstName);
            Assert.AreEqual(u.Name, UserView.Name);
            Assert.AreEqual(u.Language, UserView.Language);
            Assert.AreEqual(u.Email, UserView.Email);
            Assert.AreEqual(u.SecurId, UserView.SecurId);
            Assert.AreEqual(u.Comment, UserView.Comment);
            Assert.AreEqual(u.WesMandant, UserView.WesMandant);
        }

        public static void Create(Person person)
        {
            Contact.Open(person);

            ContactPersonView.CreateUser.Click();
            
            Assert.Equals(person.Name, UserCreate.Name);
            Assert.Equals(person.FirstName, UserCreate.FirstName);
            Assert.Equals(person.Contact.Language, UserCreate.Language);
        }
    }
}