/* RegExp
 * http://openbook.galileocomputing.de/csharp/kap17.htm
 * 
 * Strings als Parameter:
 * http://openbook.galileocomputing.de/csharp/kap19.htm
 * "Kundenname" statt k.Name Feld-Bezeichnung ist viel flexibler für zukünftige Struktur
 *  
 * http://openbook.galileocomputing.de/csharp/kap31.htm#t25
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class MenuTest
    {
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private static LobbyMenu _lobbyMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup();
            _lobbyMenu = new LobbyMenu(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _tb.ShutDownTest();
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Lobby()
        {
            Assert.IsTrue(_lobbyMenu.Lobby.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void NotAssignedTickets()
        {
            Assert.IsTrue(_lobbyMenu.Ticket.NotAssigned.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MyGroupTickets()
        {
            Assert.IsTrue(_lobbyMenu.Ticket.MyGroup.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MyTickets()
        {
            Assert.IsTrue(_lobbyMenu.Ticket.My.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationBusinessTemplateMigrate()
        {
            Assert.IsTrue(_lobbyMenu.MassMutation.BusinessTemplateMigrate.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationAcquirerChange()
        {
            Assert.IsTrue(_lobbyMenu.MassMutation.AcquirerChange.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void SimCardManagement()
        {
            Assert.IsTrue(_lobbyMenu.MassMutation.SimCardManage.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationContractCreate()
        {
            Assert.IsTrue(_lobbyMenu.MassMutation.ContractCreate.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationTerminalCreate()
        {
            Assert.IsTrue(_lobbyMenu.MassMutation.TerminalCreate.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationLocationCreate()
        {
            Assert.IsTrue(_lobbyMenu.MassMutation.LocationCreate.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationCustomerCreate()
        {
            Assert.IsTrue(_lobbyMenu.MassMutation.CustomerCreate.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void CustomerCreate()
        {
            Assert.IsTrue(_lobbyMenu.Customer.CustomerCreate.Displayed);
        }
    }
}