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
using Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class MenuTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
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
            Assert.IsTrue(TicketMenu.NotAssigned.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MyGroupTickets()
        {
            Assert.IsTrue(TicketMenu.MyGroup.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MyTickets()
        {
            Assert.IsTrue(TicketMenu.My.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void InstallationsTickets()
        {
            Assert.IsTrue(TicketMenu.Installations.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutation()
        {
            Assert.IsTrue(MassMutationMenu.MassMutation.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationBusinessTemplateMigrate()
        {
            Assert.IsTrue(MassMutationMenu.BusinessTemplateMigrate.Enabled);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationAcquirerChange()
        {
            Assert.IsTrue(MassMutationMenu.AcquirerChange.Enabled);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void SimCardManagement()
        {
            Assert.IsTrue(LobbyMenu.SimCardManage.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void HardwareManagement()
        {
            Assert.IsTrue(LobbyMenu.HardwareManage.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void SerialNumberManagement()
        {
            Assert.IsTrue(LobbyMenu.SerialNumberManage.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void BillableTerminals()
        {
            Assert.IsTrue(LobbyMenu.BillableTerminalsMenu.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void AcccessoiresOrders()
        {
            Assert.IsTrue(LobbyMenu.AcccessoiresOrders.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationContractCreate()
        {
            Assert.IsTrue(MassMutationMenu.ContractCreate.Enabled);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationTerminalCreate()
        {
            Assert.IsTrue(MassMutationMenu.TerminalCreate.Enabled);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationLocationCreate()
        {
            Assert.IsTrue(MassMutationMenu.LocationCreate.Enabled);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void MassMutationCustomerCreate()
        {
            Assert.IsTrue(MassMutationMenu.CustomerCreate.Enabled);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void CustomerCreate()
        {
            Assert.IsTrue(CustomerMenu.CustomerCreate.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void PostDeliveryTickets()
        {
            Assert.IsTrue(LobbyMenu.PostDeliveryTickets.Displayed);
        }

        [TestMethod]
        [TestCategory("LobbyCheck")]
        public void AccessoireOrders()
        {
            Assert.IsTrue(LobbyMenu.AccessoireOrders.Displayed);
        }
    }
}