using NUnit.Framework;
using Six.Scs.QA.Selenium.Administration.SimCard;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Testlogic
{
    public class SimCard
    {
        public static SimCardData Create()
        {
            SimCardData simCardData = Factory.Simcard.Create();

            Workflow.SimCard.Create(simCardData);
            Check(simCardData);
            return simCardData;
        }

        public static SimCardData Edit(SimCardData simCard)
        {
            Open(simCard);
            SimCardData simCardData = Factory.Simcard.Edit();
            Workflow.SimCard.Edit(simCardData);
            Check(simCardData);
            return simCardData;
        }

        private static void Open(SimCardData simCard)
        {
            Search.SimcardBySimCardNumber(simCard.SimCardNumber);
        }

        public static void Check(SimCardData simCardData)
        {
            Assert.AreEqual(simCardData.NetProvider, SimCardView.NetProvider);
            Assert.AreEqual(simCardData.SimCardNumber, SimCardView.SimCardNumber);
            Assert.AreEqual(simCardData.MobileNumber, SimCardView.MobileNumber);
            Assert.AreEqual(simCardData.Pin, SimCardView.Pin);
            Assert.AreEqual(simCardData.Puk, SimCardView.Puk);
            Assert.AreEqual(simCardData.Status, SimCardView.Status);
            Assert.AreEqual(simCardData.TerminalId, SimCardView.TerminalId);
        }
    }
}