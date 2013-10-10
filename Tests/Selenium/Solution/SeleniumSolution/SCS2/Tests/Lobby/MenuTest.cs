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
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class MenuTest
    {
        private static LobbyMenu _lobbyMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _lobbyMenu = new LobbyMenu();
            TestLauncher.Navigate("");
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void Lobby()
        {
            Assert.IsTrue(LobbyMenu.Lobby.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void NotAssignedTickets()
        {
            Assert.IsTrue(LobbyMenu.Ticket.NotAssigned.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MyGroupTickets()
        {
            Assert.IsTrue(LobbyMenu.Ticket.MyGroup.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MyTickets()
        {
            Assert.IsTrue(LobbyMenu.Ticket.My.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationBusinessTemplateMigrate()
        {
            Assert.IsTrue(LobbyMenu.MassMutation.BusinessTemplateMigrate.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationAcquirerChange()
        {
            Assert.IsTrue(LobbyMenu.MassMutation.AcquirerChange.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void SimCardManagement()
        {
            Assert.IsTrue(LobbyMenu.MassMutation.SimCardManage.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationContractCreate()
        {
            Assert.IsTrue(LobbyMenu.MassMutation.ContractCreate.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationTerminalCreate()
        {
            Assert.IsTrue(LobbyMenu.MassMutation.TerminalCreate.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationLocationCreate()
        {
            Assert.IsTrue(LobbyMenu.MassMutation.LocationCreate.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationCustomerCreate()
        {
            Assert.IsTrue(LobbyMenu.MassMutation.CustomerCreate.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void CustomerCreate()
        {
            Assert.IsTrue(CustomerMenu.CustomerCreate.Displayed);
        }
    }
}