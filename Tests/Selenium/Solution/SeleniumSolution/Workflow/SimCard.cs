using Six.Scs.QA.Selenium.Administration.SimCard;

namespace Six.Scs.QA.Workflow
{
    public class SimCard
    {
        public static void Create(TestData.ValueObjects.SimCard simCard)
        {
            SimCardView.CreateButton.Click();

            SimCardCreate.NetProvider = simCard.NetProvider;
            SimCardCreate.SimCardNumber = simCard.SimCardNumber;
            SimCardCreate.MobileNumber = simCard.MobileNumber;
            SimCardCreate.Pin = simCard.Pin;
            SimCardCreate.Puk = simCard.Puk;
            SimCardCreate.Region = simCard.Region;

            SimCardCreate.SaveButton.Click();
        }

        public static void Edit(TestData.ValueObjects.SimCard simCard)
        {
            SimCardView.EditButton.Click();

            SimCardEdit.NetProvider = simCard.NetProvider;
            SimCardEdit.SimCardNumber = simCard.SimCardNumber;
            SimCardEdit.MobileNumber = simCard.MobileNumber;
            SimCardEdit.Pin = simCard.Pin;
            SimCardEdit.Puk = simCard.Puk;
            SimCardEdit.Region = simCard.Region;
            SimCardEdit.Status = simCard.Status;
            SimCardEdit.TerminalId = simCard.TerminalId;
            SimCardEdit.Region = simCard.Region;
            SimCardEdit.Usage = simCard.Usage;

            SimCardEdit.SaveButton.Click();
        }
    }
}