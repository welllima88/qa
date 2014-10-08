using NUnit.Framework;
using Six.Scs.QA.Selenium.Administration.SimCard;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Testlogic
{
    public class SimCard
    {
        public static TestData.ValueObjects.SimCard Create()
        {
            NavigationBar.Lobby.Click();
            SimCardMenu.SimCardManagement.Click();

            TestData.ValueObjects.SimCard simCard = Simcard.Create();

            Workflow.SimCard.Create(simCard);
            Check(simCard);
            return simCard;
        }

        public static TestData.ValueObjects.SimCard Edit(TestData.ValueObjects.SimCard _simCard)
        {
            Open(_simCard);
            TestData.ValueObjects.SimCard simCard = Simcard.Edit();

            Workflow.SimCard.Edit(simCard);
            Check(simCard);
            return simCard;
        }

        private static void Open(TestData.ValueObjects.SimCard simCard)
        {
            Search.SimcardBySimCardNumber(simCard.SimCardNumber);
        }

        public static void Check(TestData.ValueObjects.SimCard simCard)
        {
            Assert.AreEqual(simCard.NetProvider, View.NetProvider);
            Assert.AreEqual(simCard.SimCardNumber, View.SimCardNumber);
            Assert.AreEqual(simCard.MobileNumber, View.MobileNumber);
            Assert.AreEqual(simCard.Pin, View.Pin);
            Assert.AreEqual(simCard.Puk, View.Puk);
            Assert.AreEqual(simCard.Status, View.Status);
            Assert.AreEqual(simCard.TerminalId, View.TerminalId);
        }

        public static TestData.ValueObjects.SimCard Lock(TestData.ValueObjects.SimCard sim)
        {
            Open(sim);
            Workflow.SimCard.Lock(sim);
            Check(sim);
            return sim;
        }

        public static TestData.ValueObjects.SimCard Unlink(TestData.ValueObjects.SimCard simCard)
        {
            Open(simCard);
            Workflow.SimCard.Unlink(simCard);
            Check(simCard);
            return simCard;
        }

        public static TestData.ValueObjects.SimCard Link(TestData.ValueObjects.SimCard simCard,
            TestData.ValueObjects.Terminal terminal)
        {
            Open(simCard);
            simCard.TerminalId = terminal.Id;
            Workflow.SimCard.Edit(simCard);
            Check(simCard);
            return simCard;
        }
    }
}