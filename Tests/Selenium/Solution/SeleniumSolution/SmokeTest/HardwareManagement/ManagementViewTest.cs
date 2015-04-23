using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Hardware;

namespace Six.Scs.QA.Selenium.SmokeTest.HardwareManagement
{
    [TestFixture]
    public class ManagementViewTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("HWManagement/SingleDevice");
        }

        [Test]
        [Category("HardwareManagement")]
        public void CheckButton()
        {
            Assert.That(Management.CheckButton.Displayed, Is.True);
        }

        [Test]
        [Category("HardwareManagement")]
        public void SerialNumberField()
        {
            Assert.That(Management.SerialNumber.Text(), Is.EqualTo(""));
        }
    }
}