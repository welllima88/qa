using NUnit.Framework;
using Six.Scs.QA.Selenium.Administration.SimCard;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Testlogic
{
    public class SimCard
    {
        public static TestData.ValueObjects.SimCard Create()
        {
            TestData.ValueObjects.SimCard simCard = Factory.Simcard.Create();

            Workflow.SimCard.Create(simCard);
            Check(simCard);
            return simCard;
        }

        public static TestData.ValueObjects.SimCard Edit(TestData.ValueObjects.SimCard _simCard)
        {
            Open(_simCard);
            TestData.ValueObjects.SimCard simCard = Factory.Simcard.Edit();
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
            Assert.AreEqual(simCard.NetProvider, SimCardView.NetProvider);
            Assert.AreEqual(simCard.SimCardNumber, SimCardView.SimCardNumber);
            Assert.AreEqual(simCard.MobileNumber, SimCardView.MobileNumber);
            Assert.AreEqual(simCard.Pin, SimCardView.Pin);
            Assert.AreEqual(simCard.Puk, SimCardView.Puk);
            Assert.AreEqual(simCard.Status, SimCardView.Status);
            Assert.AreEqual(simCard.TerminalId, SimCardView.TerminalId);
        }
    }
}