using NUnit.Framework;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Common.Menu;

namespace Six.Scs.Test
{
    public class SimCard
    {
        public static Test.Model.ValueObjects.SimCard Create()
        {
            NavigationBar.Lobby.Click();
            LobbyMenu.SimCardManage.Click();

            Test.Model.ValueObjects.SimCard simCard = Simcard.Create();

            Test.Workflow.SimCard.Create(simCard);
            Check(simCard);
            return simCard;
        }

        public static Test.Model.ValueObjects.SimCard Edit(Test.Model.ValueObjects.SimCard _simCard)
        {
            Open(_simCard);
            Test.Model.ValueObjects.SimCard simCard = Simcard.Edit();

            Test.Workflow.SimCard.Edit(simCard);
            Check(simCard);
            return simCard;
        }

        private static void Open(Test.Model.ValueObjects.SimCard simCard)
        {
            Search.SimcardBySimCardNumber(simCard.SimCardNumber);
        }

        public static void Check(Test.Model.ValueObjects.SimCard simCard)
        {
            Assert.AreEqual(simCard.NetProvider, View.Administration.SimCard.View.NetProvider);
            Assert.AreEqual(simCard.SimCardNumber, View.Administration.SimCard.View.SimCardNumber);
            Assert.AreEqual(simCard.MobileNumber, View.Administration.SimCard.View.MobileNumber);
            Assert.AreEqual(simCard.Pin, View.Administration.SimCard.View.Pin);
            Assert.AreEqual(simCard.Puk, View.Administration.SimCard.View.Puk);
            Assert.AreEqual(simCard.Status, View.Administration.SimCard.View.Status);
            Assert.AreEqual(simCard.TerminalId, View.Administration.SimCard.View.TerminalId);
        }

        public static Test.Model.ValueObjects.SimCard Lock(Test.Model.ValueObjects.SimCard sim)
        {
            Open(sim);
            Test.Workflow.SimCard.Lock(sim);
            Check(sim);
            return sim;
        }

        public static Test.Model.ValueObjects.SimCard Unlink(Test.Model.ValueObjects.SimCard simCard)
        {
            Open(simCard);
            Test.Workflow.SimCard.Unlink(simCard);
            Check(simCard);
            return simCard;
        }

        public static Test.Model.ValueObjects.SimCard Link(Test.Model.ValueObjects.SimCard simCard,
            Test.Model.ValueObjects.Terminal terminal)
        {
            Open(simCard);
            simCard.TerminalId = terminal.Id;
            Test.Workflow.SimCard.Edit(simCard);
            Check(simCard);
            return simCard;
        }
    }
}