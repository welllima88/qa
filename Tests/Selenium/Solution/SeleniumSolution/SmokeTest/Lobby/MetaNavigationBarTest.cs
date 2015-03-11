using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Common;

namespace Six.Scs.QA.Selenium.SmokeTest.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class MetaNavigationBarTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();

            MetaNavBar.Languages.Click();
            MetaNavBar.Languages.Click();
        }

        [Test]
        [Category("LobbyCheck")]
        public void CompanyLogo()
        {
            Assert.IsTrue(MetaNavBar.CompanyLogo.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void LanguageEnglish()
        {
            Assert.That(MetaNavBar.LanguageItems.Select(e => e.Text), Contains.Item("English"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void LanguageGerman()
        {
            Assert.That(MetaNavBar.LanguageItems.Select(e => e.Text), Contains.Item("Deutsch"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void Languages()
        {
            Assert.IsTrue(MetaNavBar.Languages.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void LogOff()
        {
            Assert.That(MetaNavBar.LogOff.Displayed);
            Assert.That(MetaNavBar.LogOff.Text, Is.EqualTo("Abmelden"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void User()
        {
            Assert.IsTrue(MetaNavBar.User.Displayed);
        }
    }
}