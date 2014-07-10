using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

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
        }

        [Test]
        [Category("LobbyCheck")]
        public void LanguageEnglish()
        {
            MetaNavBar.Languages.Click();
            Assert.IsTrue(MetaNavBar.LanguageItem("English").Enabled);
            MetaNavBar.Languages.Click();
        }

        [Test]
        [Category("LobbyCheck")]
        public void LanguageGerman()
        {
            MetaNavBar.Languages.Click();
            Assert.IsTrue(MetaNavBar.LanguageItem("Deutsch").Enabled);
            MetaNavBar.Languages.Click();
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
            Assert.IsTrue(MetaNavBar.LogOff.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void User()
        {
            Assert.IsTrue(MetaNavBar.User.Displayed);
        }
    }
}