using Six.Scs.QA.Selenium.Administration.SimCard;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow
{
    public class SimCard
    {
        public static void Create(SimCardData simCardData)
        {
            SimCardMenu.SimCardManagement.Click();
            
            SimCardCreate.NetProvider = simCardData.NetProvider;
            SimCardCreate.SimCardNumber = simCardData.SimCardNumber;
            SimCardCreate.MobileNumber = simCardData.MobileNumber;
            SimCardCreate.Pin = simCardData.Pin;
            SimCardCreate.Puk = simCardData.Puk;
            SimCardCreate.Region = simCardData.Region;

            SimCardCreate.SaveButton.Click();
        }

        public static void Edit(SimCardData simCardData)
        {
            SimCardView.EditButton.Click();

            SimCardCreate.NetProvider = simCardData.NetProvider;
            SimCardCreate.SimCardNumber = simCardData.SimCardNumber;
            SimCardCreate.MobileNumber = simCardData.MobileNumber;
            SimCardCreate.Pin = simCardData.Pin;
            SimCardCreate.Puk = simCardData.Puk;
            SimCardCreate.Region = simCardData.Region;

            SimCardEdit.Status = simCardData.Status;
            SimCardEdit.TerminalId = simCardData.TerminalId;
            SimCardEdit.Region = simCardData.Region;
            SimCardEdit.Usage = simCardData.Usage;

            SimCardEdit.SaveButton.Click();
        }
    }
}