using NUnit.Framework;
using Six.Scs.Test.UI.Common;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class ApplicationInfoTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
        }

        [Category("LobbyCheck")]
        [Test]
        public void ApplicationName()
        {
            Assert.That(ApplicationInfo.ApplicationName.Displayed);
            Assert.That(ApplicationInfo.ApplicationName.Text, Is.EqualTo("SCS2"));
        }

        [Category("LobbyCheck")]
        [Test]
        public void Environment()
        {
            Assert.That(ApplicationInfo.Environment.Displayed);
        }

        [Category("LobbyCheck")]
        [Test]
        public void SupportContact()
        {
            ApplicationInfo.Support.Click();

            Assert.That(ApplicationInfo.SupportDialog.Displayed);

            Assert.That(ApplicationInfo.SupportDialog.Text, Contains.Substring("Support"));
            Assert.That(ApplicationInfo.SupportDialog.Text, Contains.Substring("SCS2"));
            Assert.That(ApplicationInfo.SupportDialog.Text, Contains.Substring("@six-group.com"));
            Assert.That(ApplicationInfo.SupportDialog.Text, Contains.Substring("+41 58 399"));
        }
    }
}