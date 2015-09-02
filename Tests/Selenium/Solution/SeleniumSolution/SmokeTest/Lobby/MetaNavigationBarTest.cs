using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.UI.Common;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Lobby
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
            Assert.That(MetaNavBar.CompanyLogo.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void LanguageEnglish()
        {
            // be careful with  using the Assert, because seems to contain an error
            // Assert.That(.., Contains.Item("English"));
            Assert.That(MetaNavBar.LanguageItems.Select(e => e.Text).ToList().Contains("English"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void LanguageGerman()
        {
            Assert.That(MetaNavBar.LanguageItems.Select(e => e.Text).ToList().Contains("Deutsch"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void Languages()
        {
            Assert.That(MetaNavBar.Languages.Displayed);
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
            Assert.That(MetaNavBar.User.Displayed);
        }
    }
}