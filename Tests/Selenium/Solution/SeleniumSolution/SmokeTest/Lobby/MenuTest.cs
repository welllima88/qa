﻿using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

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
            Assert.IsTrue(LobbyMenu.AcccessoiresOrders.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void AccessoireOrders()
        {
            Assert.IsTrue(LobbyMenu.AccessoireOrders.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void BillableTerminals()
        {
            Assert.IsTrue(LobbyMenu.BillableTerminalsMenu.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void CustomerCreate()
        {
            Assert.IsTrue(CustomerMenu.CustomerCreate.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void HardwareManagement()
        {
            Assert.IsTrue(LobbyMenu.HardwareManage.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void InstallationsTickets()
        {
            Assert.IsTrue(TicketMenu.Installations.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void Lobby()
        {
            Assert.IsTrue(LobbyMenu.Lobby.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MassMutation()
        {
            Assert.IsTrue(MassMutationMenu.MassMutation.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MassMutationAcquirerChange()
        {
            Assert.IsTrue(MassMutationMenu.AcquirerChange.Enabled);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MassMutationBusinessTemplateMigrate()
        {
            Assert.IsTrue(MassMutationMenu.BusinessTemplateMigrate.Enabled);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MassMutationContractCreate()
        {
            Assert.IsTrue(MassMutationMenu.ContractCreate.Enabled);
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
            Assert.IsTrue(MassMutationMenu.LocationCreate.Enabled);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MassMutationTerminalCreate()
        {
            Assert.IsTrue(MassMutationMenu.TerminalCreate.Enabled);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MyGroupTickets()
        {
            Assert.IsTrue(TicketMenu.MyGroup.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void MyTickets()
        {
            Assert.IsTrue(TicketMenu.My.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void NotAssignedTickets()
        {
            Assert.IsTrue(TicketMenu.NotAssigned.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void PostDeliveryTickets()
        {
            Assert.IsTrue(LobbyMenu.PostDeliveryTickets.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void SerialNumberManagement()
        {
            Assert.IsTrue(LobbyMenu.SerialNumberManage.Displayed);
        }

        [Test]
        [Category("LobbyCheck")]
        public void SimCardManagement()
        {
            Assert.IsTrue(LobbyMenu.SimCardManage.Displayed);
        }
    }
}