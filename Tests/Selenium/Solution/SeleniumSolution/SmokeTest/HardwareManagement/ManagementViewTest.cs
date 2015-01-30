﻿using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Hardware;

namespace Six.Scs.QA.Selenium.SmokeTest.HardwareManagement
{
    [TestFixture]
    public class ManagementViewTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("HWManagement/");
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