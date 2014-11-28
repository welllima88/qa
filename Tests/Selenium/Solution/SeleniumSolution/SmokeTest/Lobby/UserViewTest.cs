using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.User;

namespace Six.Scs.QA.Selenium.SmokeTest.Lobby
{
    [TestFixture]
    [Ignore("because this changes last element history and causes side effects to the regression test")]
    public class UserViewTest
    {
        [TestFixtureSetUp]
        public static void NavigateToUser()
        {
            TestDirector.Navigate("User/Index?UserName=six_scs_auto");
        }

        [Test]
        [Category("SmokeTest")]
        public void Comment()
        {
            Assert.AreEqual("DO NOT DELETE", View.Comment);
        }

        [Test]
        [Category("SmokeTest")]
        public void Created()
        {
            StringAssert.Contains("25.07.2012", View.Created);
        }

        [Test]
        [Category("SmokeTest")]
        public void EditButton()
        {
            Assert.IsTrue(View.Edit.Displayed);
        }

        [Test]
        [Category("SmokeTest")]
        public void Email()
        {
            Assert.AreEqual("marc.siegmund@six-group.com", View.Email);
        }

        [Test]
        [Category("SmokeTest")]
        public void FirstName()
        {
            Assert.AreEqual("Automatisierer", View.FirstName);
        }

        [Test]
        [Category("SmokeTest")]
        public void Language()
        {
            Assert.AreEqual("Deutsch [de]", View.Language);
        }

        [Test]
        [Category("SmokeTest")]
        public void LastLogOn()
        {
            Assert.IsTrue(DateTime.Now.CompareTo(DateTime.Parse(View.LastLogOn)) > 0);
            Assert.IsTrue(DateTime.Now.AddDays(-1).CompareTo(DateTime.Parse(View.LastLogOn)) < 0);
        }

        [Test]
        [Category("SmokeTest")]
        public void LastName()
        {
            Assert.AreEqual("SCS", View.Name);
        }

        [Test]
        [Category("SmokeTest")]
        public void ReactivateButton()
        {
            Assert.IsTrue(View.ReactivateButton.Displayed);
        }

        [Test]
        [Category("SmokeTest")]
        public void SecureId()
        {
            Assert.AreEqual("tksyr", View.SecurId);
        }

        [Test]
        [Category("SmokeTest")]
        public void UserName()
        {
            Assert.AreEqual("six_scs_auto", View.UserName);
        }

        [Test]
        [Category("SmokeTest")]
        public void UserSalutation()
        {
            Assert.AreEqual("Herr", View.Salutation);
        }

        [Test]
        [Category("SmokeTest")]
        public void WesMandant()
        {
            StringAssert.Contains(View.WesMandant, "TKCPOS");
        }
    }
}