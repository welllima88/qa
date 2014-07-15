using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.User;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class User
    {
        public static UserData Create(CustomerData customer)
        {
            Customer.Open(customer);
            UserData user = UserFactory.Create();
            Workflow.User.Create(user);

            Check(user);
            Lobby.OpenLatestElement();
            Check(user);
            return user;
        }

        public static UserData Edit(UserData user)
        {
            throw new NotImplementedException();
        }

        public static void Open(UserData user)
        {
            Search.UserCanBeFoundByCustomerName(user.UserName);
        }
        public static void Check(UserData u)
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
    }
}