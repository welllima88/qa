using System.Text.RegularExpressions;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal.Duplicate;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.Duplicate
{
    [TestFixture]
    public class TerminalDuplicateDefaultsGuiTest
    {
        [SetUp]
        public void TestInit()
        {
            TestDirector.Navigate("TerminalDuplicate?TerminalId=21013049");
        }

        [Test]
        public void NumberOfTerminals()
        {
            Assert.AreEqual("1", View.NumberOfTerminals);
        }

        [Test]
        public void CopyPassword()
        {
            Assert.AreEqual(false, View.CopyPassword);
        }

        [Test]
        public void AcquirerNotification()
        {
            Assert.AreEqual(false, View.AcquirerNotification);
        }

        [Test]
        public void Location()
        {
            StringAssert.IsMatch(View.Location, new Regex(TestRegExpPatterns.NotEmpty));
        }

        [Test]
        public void InstallationMessage()
        {
            Assert.AreEqual("", View.InstallationMessage);
        }
    }
}