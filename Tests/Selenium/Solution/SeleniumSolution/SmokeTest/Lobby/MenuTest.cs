using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Common.Menu;

namespace Six.Scs.QA.Selenium.SmokeTest.Lobby
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class MenuTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
        }

        [Test]
        [Category("LobbyCheck")]
        public void AcccessoiresOrders()
        {
            Assert.That(LobbyMenu.AcccessoiresOrders.Displayed);
            Assert.That(LobbyMenu.AcccessoiresOrders.Text, Contains.Substring("Kleinmaterial Bestellungen"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void CustomerCreate()
        {
            Assert.That(CustomerMenu.CustomerCreate.Displayed);
            Assert.That(CustomerMenu.CustomerCreate.Text, Contains.Substring("Neuer Kunde"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void HardwareManagement()
        {
            Assert.That(LobbyMenu.HardwareManage.Displayed);
            Assert.That(LobbyMenu.HardwareManage.Text, Contains.Substring("Hardware-Verwaltung"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void InstallationsTickets()
        {
            Assert.That(TicketMenu.Installations.Displayed);
            Assert.That(TicketMenu.Installations.Text, Contains.Substring("Installation / Wartung"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void Lobby()
        {
            Assert.That(LobbyMenu.Lobby.Displayed);
            Assert.That(LobbyMenu.Lobby.Text, Contains.Substring("Lobby"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void MassMutation()
        {
            Assert.That(MassMutationMenu.MassMutation.Displayed);
            Assert.That(MassMutationMenu.MassMutation.Text, Contains.Substring("Massenmutation"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void MassMutationAcquirerChange()
        {
            Assert.That(MassMutationMenu.AcquirerChange.Enabled);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MassMutationContractCreate()
        {
            Assert.That(MassMutationMenu.ContractCreate.Enabled);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MassMutationCustomerCreate()
        {
            Assert.IsTrue(MassMutationMenu.CustomerCreate.Enabled);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MassMutationLocationCreate()
        {
            Assert.That(MassMutationMenu.LocationCreate.Enabled);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MassMutationTerminalCreate()
        {
            Assert.IsTrue(MassMutationMenu.TerminalCreate.Enabled);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MyIncidents()
        {
            Assert.IsTrue(LobbyMenu.MyIncidents.Enabled);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MyTeams()
        {
            Assert.IsTrue(LobbyMenu.MyTeams.Enabled);
        }

        [Test]
        [Category("LobbyCheck")]
        public void SerialNumberManagement()
        {
            Assert.That(LobbyMenu.SerialNumberManage.Displayed);
            Assert.That(LobbyMenu.SerialNumberManage.Text, Contains.Substring("Seriennummernverwaltung"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void SimCardManagement()
        {
            Assert.That(LobbyMenu.SimCardManage.Displayed);
            Assert.That(LobbyMenu.SimCardManage.Text, Contains.Substring("SIM-Kartenverwaltung"));
        }

        [Test]
        [Category("LobbyCheck")]
        public void TerminalReturnShipping()
        {
            Assert.That(LobbyMenu.TerminalReturnShipping.Displayed);
            Assert.That(LobbyMenu.TerminalReturnShipping.Text, Contains.Substring("Terminal Rücknahmen"));
        }
    }
}