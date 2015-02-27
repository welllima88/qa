﻿using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Common;

namespace Six.Scs.QA.Selenium.SmokeTest.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class RecentElementsTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
        }

        [Test]
        [Category("LobbyCheck")]
        public void MostRecentContainer()
        {
            Assert.IsTrue(RecentElements.Latest.Displayed);
        }
    }
}