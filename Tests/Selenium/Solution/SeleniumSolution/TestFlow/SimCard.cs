using NUnit.Framework;
using Six.Scs.QA.Application.Model.Factory;
using Six.Scs.QA.Application.View.Administration.SimCard;
using Six.Scs.QA.Application.View.Common;
using Six.Scs.QA.Application.View.Common.Menu;

namespace Six.Scs.QA.Testlogic
{
    public class SimCard
    {
        public static Application.Model.ValueObjects.SimCard Create()
        {
            NavigationBar.Lobby.Click();
            LobbyMenu.SimCardManage.Click();

            Application.Model.ValueObjects.SimCard simCard = Simcard.Create();

            Application.Workflow.SimCard.Create(simCard);
            Check(simCard);
            return simCard;
        }

        public static Application.Model.ValueObjects.SimCard Edit(Application.Model.ValueObjects.SimCard _simCard)
        {
            Open(_simCard);
            Application.Model.ValueObjects.SimCard simCard = Simcard.Edit();

            Application.Workflow.SimCard.Edit(simCard);
            Check(simCard);
            return simCard;
        }

        private static void Open(Application.Model.ValueObjects.SimCard simCard)
        {
            Search.SimcardBySimCardNumber(simCard.SimCardNumber);
        }

        public static void Check(Application.Model.ValueObjects.SimCard simCard)
        {
            Assert.AreEqual(simCard.NetProvider, View.NetProvider);
            Assert.AreEqual(simCard.SimCardNumber, View.SimCardNumber);
            Assert.AreEqual(simCard.MobileNumber, View.MobileNumber);
            Assert.AreEqual(simCard.Pin, View.Pin);
            Assert.AreEqual(simCard.Puk, View.Puk);
            Assert.AreEqual(simCard.Status, View.Status);
            Assert.AreEqual(simCard.TerminalId, View.TerminalId);
        }

        public static Application.Model.ValueObjects.SimCard Lock(Application.Model.ValueObjects.SimCard sim)
        {
            Open(sim);
            Application.Workflow.SimCard.Lock(sim);
            Check(sim);
            return sim;
        }

        public static Application.Model.ValueObjects.SimCard Unlink(Application.Model.ValueObjects.SimCard simCard)
        {
            Open(simCard);
            Application.Workflow.SimCard.Unlink(simCard);
            Check(simCard);
            return simCard;
        }

        public static Application.Model.ValueObjects.SimCard Link(Application.Model.ValueObjects.SimCard simCard,
            Application.Model.ValueObjects.Terminal terminal)
        {
            Open(simCard);
            simCard.TerminalId = terminal.Id;
            Application.Workflow.SimCard.Edit(simCard);
            Check(simCard);
            return simCard;
        }
    }
}