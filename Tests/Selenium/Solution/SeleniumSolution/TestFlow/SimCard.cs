using NUnit.Framework;
using Six.Scs.QA.Selenium.Model.Factory;
using Six.Scs.QA.Selenium.View.Administration.SimCard;
using Six.Scs.QA.Selenium.View.Common;
using Six.Scs.QA.Selenium.View.Common.Menu;

namespace Six.Scs.QA.Testlogic
{
    public class SimCard
    {
        public static Selenium.Model.ValueObjects.SimCard Create()
        {
            NavigationBar.Lobby.Click();
            LobbyMenu.SimCardManage.Click();

            Selenium.Model.ValueObjects.SimCard simCard = Simcard.Create();

            Selenium.Workflow.SimCard.Create(simCard);
            Check(simCard);
            return simCard;
        }

        public static Selenium.Model.ValueObjects.SimCard Edit(Selenium.Model.ValueObjects.SimCard _simCard)
        {
            Open(_simCard);
            Selenium.Model.ValueObjects.SimCard simCard = Simcard.Edit();

            Selenium.Workflow.SimCard.Edit(simCard);
            Check(simCard);
            return simCard;
        }

        private static void Open(Selenium.Model.ValueObjects.SimCard simCard)
        {
            Search.SimcardBySimCardNumber(simCard.SimCardNumber);
        }

        public static void Check(Selenium.Model.ValueObjects.SimCard simCard)
        {
            Assert.AreEqual(simCard.NetProvider, View.NetProvider);
            Assert.AreEqual(simCard.SimCardNumber, View.SimCardNumber);
            Assert.AreEqual(simCard.MobileNumber, View.MobileNumber);
            Assert.AreEqual(simCard.Pin, View.Pin);
            Assert.AreEqual(simCard.Puk, View.Puk);
            Assert.AreEqual(simCard.Status, View.Status);
            Assert.AreEqual(simCard.TerminalId, View.TerminalId);
        }

        public static Selenium.Model.ValueObjects.SimCard Lock(Selenium.Model.ValueObjects.SimCard sim)
        {
            Open(sim);
            Selenium.Workflow.SimCard.Lock(sim);
            Check(sim);
            return sim;
        }

        public static Selenium.Model.ValueObjects.SimCard Unlink(Selenium.Model.ValueObjects.SimCard simCard)
        {
            Open(simCard);
            Selenium.Workflow.SimCard.Unlink(simCard);
            Check(simCard);
            return simCard;
        }

        public static Selenium.Model.ValueObjects.SimCard Link(Selenium.Model.ValueObjects.SimCard simCard,
            Selenium.Model.ValueObjects.Terminal terminal)
        {
            Open(simCard);
            simCard.TerminalId = terminal.Id;
            Selenium.Workflow.SimCard.Edit(simCard);
            Check(simCard);
            return simCard;
        }
    }
}