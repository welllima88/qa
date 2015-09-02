using NUnit.Framework;
using Six.Scs.Test.Factory;
using Six.Scs.Test.UI.Administration.SimCard;
using Six.Scs.Test.UI.Common;
using Six.Scs.Test.UI.Common.Menu;

namespace Six.Scs.Test
{
    public class SimCard
    {
        public static Model.SimCard Create()
        {
            NavigationBar.Lobby.Click();
            LobbyMenu.SimCardManage.Click();

            var simCard = Simcard.Create();

            Workflow.SimCard.Create(simCard);
            Check(simCard);
            return simCard;
        }

        public static Model.SimCard Edit(Model.SimCard _simCard)
        {
            Open(_simCard);
            var simCard = Simcard.Edit();

            Workflow.SimCard.Edit(simCard);
            Check(simCard);
            return simCard;
        }

        private static void Open(Model.SimCard simCard)
        {
            Search.SimcardBySimCardNumber(simCard.SimCardNumber);
        }

        public static void Check(Model.SimCard simCard)
        {
            Assert.AreEqual(simCard.NetProvider, View.NetProvider);
            Assert.AreEqual(simCard.SimCardNumber, View.SimCardNumber);
            Assert.AreEqual(simCard.MobileNumber, View.MobileNumber);
            Assert.AreEqual(simCard.Pin, View.Pin);
            Assert.AreEqual(simCard.Puk, View.Puk);
            Assert.AreEqual(simCard.Status, View.Status);
            Assert.AreEqual(simCard.TerminalId, View.TerminalId);
        }

        public static Model.SimCard Lock(Model.SimCard sim)
        {
            Open(sim);
            Workflow.SimCard.Lock(sim);
            Check(sim);
            return sim;
        }

        public static Model.SimCard Unlink(Model.SimCard simCard)
        {
            Open(simCard);
            Workflow.SimCard.Unlink(simCard);
            Check(simCard);
            return simCard;
        }

        public static Model.SimCard Link(Model.SimCard simCard,
            Model.Terminal terminal)
        {
            Open(simCard);
            simCard.TerminalId = terminal.Id;
            Workflow.SimCard.Edit(simCard);
            Check(simCard);
            return simCard;
        }
    }
}