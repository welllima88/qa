using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Common;

namespace Six.Scs.QA.Selenium.SmokeTest.Lobby
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
            Assert.IsTrue(ApplicationInfo.ApplicationName.Displayed);
        }

        [Category("LobbyCheck")]
        [Test]
        public void Environment()
        {
            Assert.IsTrue(ApplicationInfo.Environment.Displayed);
        }

        [Category("LobbyCheck")]
        [Test]
        public void SupportContact()
        {
            ApplicationInfo.Support.Click();

            Assert.IsTrue(ApplicationInfo.SupportDialog.Displayed);

            StringAssert.Contains("Support", ApplicationInfo.SupportDialog.Text);
            StringAssert.Contains("SCS2", ApplicationInfo.SupportDialog.Text);
            StringAssert.Contains("@six-group.com", ApplicationInfo.SupportDialog.Text);
            StringAssert.Contains("+41 58 399", ApplicationInfo.SupportDialog.Text);
        }
    }
}