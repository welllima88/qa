using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class ProcessTicketsTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
        }

        [Test]
        [Category("LobbyCheck")]
        public void NewestProcessTickets()
        {
            Assert.IsTrue(ProcessTickets.Newest.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void OldestProcessTickets()
        {
            Assert.IsTrue(ProcessTickets.Oldest.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void ProcessTicketsContainer()
        {
            Assert.IsTrue(ProcessTickets.Container.Displayed);
        }
    }
}