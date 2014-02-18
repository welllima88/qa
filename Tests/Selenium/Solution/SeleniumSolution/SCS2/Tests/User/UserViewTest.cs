using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.User;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.User
{
    [TestClass]
    public class UserViewTest
    {
        [ClassInitialize]
        public static void NavigateToUser(TestContext testContext)
        {
            TestDirector.Navigate("User/Index?UserName=six_scs_auto");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            CustomerMenu.CustomerDeactivate.Click();
        }

        [TestMethod]
        public void UserName()
        {
            Assert.AreEqual("six_scs_auto", UserView.UserName);
        }

        [TestMethod]
        public void UserPassword()
        {
            Assert.AreEqual("", UserView.Password);
        }

        [TestMethod]
        public void UserSalutation()
        {
            Assert.AreEqual("Herr", UserView.Salutation);
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual("Automatisierer", UserView.FirstName);
        }

        [TestMethod]
        public void LastName()
        {
            Assert.AreEqual("SCS", UserView.LastName);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("marc.siegmund@six-group.com", UserView.Email);
        }

        [TestMethod]
        public void Language()
        {
            Assert.AreEqual("Deutsch [de]", UserView.Language);
        }

        [TestMethod]
        public void SecureId()
        {
            Assert.AreEqual("tksyr", UserView.SecureId);
        }

        [TestMethod]
        public void WesMandant()
        {
            StringAssert.Contains(UserView.WesMandant, "TKCPOS");
        }

        [TestMethod]
        public void LastLogin()
        {
            new NotImplementedException("to bed done because of date");
            // TODO : Assert.AreEqual(DateTime.Parse(UserView.LastLogin));
        }

        [TestMethod]
        public void Created()
        {
            StringAssert.Contains(UserView.Created, "25.07.2012");
        }

        [TestMethod]
        public void Comment()
        {
            Assert.AreEqual("DO NOT DELETE", UserView.Comment);
        }

        [TestMethod]
        public void EditButton()
        {
            Assert.IsTrue(UserView.EditButton.Displayed);
        }

        [TestMethod]
        public void ListUsersButton()
        {
            Assert.IsTrue(UserView.ListUsersButton.Displayed);
        }

        [TestMethod]
        public void ReactivateButton()
        {
            Assert.IsTrue(UserView.ReactivateButton.Displayed);
        }
    }
}