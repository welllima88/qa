﻿using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Application.View.Terminal.Dashboard.Portlets;

namespace Six.Scs.QA.Application.SmokeTest.Terminal
{
    [TestFixture]
    public class FoMessage
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
            Activity.FoMessages.Click();
        }

        [Test]
        public void Date()
        {
            Assert.That(View.Terminal.FoMessages.FoMessage.Date, Is.Not.Empty);
        }

        [Test]
        public void Id()
        {
            Assert.That(View.Terminal.FoMessages.FoMessage.Id, Is.Not.Empty);
        }

        [Test]
        public void JobId()
        {
            Assert.That(View.Terminal.FoMessages.FoMessage.JobId, Is.Not.Empty);
        }

        [Test]
        public void ResponseCode()
        {
            Assert.That(View.Terminal.FoMessages.FoMessage.ResponseCode, Is.Not.Empty);
        }

        [Test]
        public void TerminalId()
        {
            Assert.That(View.Terminal.FoMessages.FoMessage.TerminalId, Is.Not.Empty);
        }

        [Test]
        public void UserName()
        {
            Assert.That(View.Terminal.FoMessages.FoMessage.UserName, Is.Not.Empty);
        }
    }
}