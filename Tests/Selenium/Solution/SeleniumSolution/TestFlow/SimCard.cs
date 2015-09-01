using NUnit.Framework;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Common.Menu;

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
            Assert.AreEqual(simCard.NetProvider, View.Administration.SimCard.View.NetProvider);
            Assert.AreEqual(simCard.SimCardNumber, View.Administration.SimCard.View.SimCardNumber);
            Assert.AreEqual(simCard.MobileNumber, View.Administration.SimCard.View.MobileNumber);
            Assert.AreEqual(simCard.Pin, View.Administration.SimCard.View.Pin);
            Assert.AreEqual(simCard.Puk, View.Administration.SimCard.View.Puk);
            Assert.AreEqual(simCard.Status, View.Administration.SimCard.View.Status);
            Assert.AreEqual(simCard.TerminalId, View.Administration.SimCard.View.TerminalId);
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