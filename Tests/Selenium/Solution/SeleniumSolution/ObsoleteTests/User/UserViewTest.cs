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
            Assert.AreEqual("six_scs_auto", View.UserName);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void UserPassword()
        {
            Assert.AreEqual("", View.Password);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void UserSalutation()
        {
            Assert.AreEqual("Herr", View.Salutation);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void FirstName()
        {
            Assert.AreEqual("Automatisierer", View.FirstName);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void LastName()
        {
            Assert.AreEqual("SCS", View.Name);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void Email()
        {
            Assert.AreEqual("marc.siegmund@six-group.com", View.Email);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void Language()
        {
            Assert.AreEqual("Deutsch [de]", View.Language);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void SecureId()
        {
            Assert.AreEqual("tksyr", View.SecurId);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void WesMandant()
        {
            StringAssert.Contains(View.WesMandant, "TKCPOS");
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void LastLogOn()
        {
            Assert.IsTrue(DateTime.Now.CompareTo(DateTime.Parse(View.LastLogOn)) > 0);
            Assert.IsTrue(DateTime.Now.AddDays(-1).CompareTo(DateTime.Parse(View.LastLogOn)) < 0);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void Created()
        {
            StringAssert.Contains(View.Created, "25.07.2012");
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void Comment()
        {
            Assert.AreEqual("DO NOT DELETE", View.Comment);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void EditButton()
        {
            Assert.IsTrue(View.EditButton.Displayed);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void ReactivateButton()
        {
            Assert.IsTrue(View.ReactivateButton.Displayed);
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        public void MenuTest()
        {
            MenusTest.UserMenuCheck();
        }
    }
}