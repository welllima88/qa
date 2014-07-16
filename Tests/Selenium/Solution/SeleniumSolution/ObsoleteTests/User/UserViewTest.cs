using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.ObsoleteTests.Menu;
using Six.Scs.QA.Selenium.User;

namespace Six.Scs.QA.Selenium.ObsoleteTests.User
{
    [TestClass]
    public class UserViewTest
    {
        [ClassInitialize]
        public static void NavigateToUser(TestContext testContext)
        {
            TestDirector.Navigate("User/Index?UserName=six_scs_auto");
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void UserName()
        {
            Assert.AreEqual("six_scs_auto", UserView.UserName);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void UserPassword()
        {
            Assert.AreEqual("", UserView.Password);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void UserSalutation()
        {
            Assert.AreEqual("Herr", UserView.Salutation);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void FirstName()
        {
            Assert.AreEqual("Automatisierer", UserView.FirstName);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void LastName()
        {
            Assert.AreEqual("SCS", UserView.Name);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void Email()
        {
            Assert.AreEqual("marc.siegmund@six-group.com", UserView.Email);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void Language()
        {
            Assert.AreEqual("Deutsch [de]", UserView.Language);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void SecureId()
        {
            Assert.AreEqual("tksyr", UserView.SecurId);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void WesMandant()
        {
            StringAssert.Contains(UserView.WesMandant, "TKCPOS");
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void LastLogOn()
        {
            Assert.IsTrue(DateTime.Now.CompareTo(DateTime.Parse(UserView.LastLogOn)) > 0);
            Assert.IsTrue(DateTime.Now.AddDays(-1).CompareTo(DateTime.Parse(UserView.LastLogOn)) < 0);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void Created()
        {
            StringAssert.Contains(UserView.Created, "25.07.2012");
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void Comment()
        {
            Assert.AreEqual("DO NOT DELETE", UserView.Comment);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void EditButton()
        {
            Assert.IsTrue(UserView.EditButton.Displayed);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void ReactivateButton()
        {
            Assert.IsTrue(UserView.ReactivateButton.Displayed);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void MenuTest()
        {
            MenusTest.UserMenuCheck();
        }
    }
}