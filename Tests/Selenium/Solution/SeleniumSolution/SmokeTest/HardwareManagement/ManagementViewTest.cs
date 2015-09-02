using NUnit.Framework;
using Six.Scs.Test.UI.Hardware;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.HardwareManagement
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