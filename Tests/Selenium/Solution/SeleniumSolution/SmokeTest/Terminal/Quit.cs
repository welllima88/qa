﻿using NUnit.Framework;
using Six.Scs.Test.UI.Terminal.Dashboard.Portlets;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Terminal
{
    [TestFixture]
    [Category("Terminal Quit")]
    public class Quit
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
            SalesContract.Quit.Click();
            
        }

        [Test]
        [Category("Terminal Quit")]
        public void Delivery()
        {
            Assert.That(UI.Terminal.Quit.Quit.InstallationOnSiteRequested, Is.False);
        }

        [Test]
        [Category("Terminal Quit")]
        public void Reason()
        {
            Assert.That(UI.Terminal.Quit.Quit.Reason, Is.Not.Null);
            Assert.That(UI.Terminal.Quit.Quit.Reason, Is.Empty);
        }

        [Test]
        [Category("Terminal Quit")]
        public void State()
        {
            Assert.That(UI.Terminal.Quit.Quit.State, Is.Not.Empty);
        }
    }
}