using Six.Scs.QA.Selenium.Administration.SimCard;

namespace Six.Scs.QA.Workflow
{
    public class SimCard
    {
        public static void Create(TestData.ValueObjects.SimCard simCard)
        {
            View.CreateButton.Click();

            Selenium.Administration.SimCard.Create.NetProvider = simCard.NetProvider;
            Selenium.Administration.SimCard.Create.SimCardNumber = simCard.SimCardNumber;
            Selenium.Administration.SimCard.Create.MobileNumber = simCard.MobileNumber;
            Selenium.Administration.SimCard.Create.Pin = simCard.Pin;
            Selenium.Administration.SimCard.Create.Puk = simCard.Puk;
            Selenium.Administration.SimCard.Create.Region = simCard.Region;

            Selenium.Administration.SimCard.Create.SaveButton.Click();
        }

        public static void Edit(TestData.ValueObjects.SimCard simCard)
        {
            View.EditButton.Click();

            Selenium.Administration.SimCard.Edit.NetProvider = simCard.NetProvider;
            Selenium.Administration.SimCard.Edit.SimCardNumber = simCard.SimCardNumber;
            Selenium.Administration.SimCard.Edit.MobileNumber = simCard.MobileNumber;
            Selenium.Administration.SimCard.Edit.Pin = simCard.Pin;
            Selenium.Administration.SimCard.Edit.Puk = simCard.Puk;
            Selenium.Administration.SimCard.Edit.Region = simCard.Region;
            Selenium.Administration.SimCard.Edit.Status = simCard.Status;
            Selenium.Administration.SimCard.Edit.TerminalId = simCard.TerminalId;
            Selenium.Administration.SimCard.Edit.Region = simCard.Region;
            Selenium.Administration.SimCard.Edit.Usage = simCard.Usage;

            Selenium.Administration.SimCard.Edit.SaveButton.Click();
        }

        public static void Lock(TestData.ValueObjects.SimCard sim)
        {
            View.LockButton.Click();
            sim.Status = false;
        }

        public static void Unlink(TestData.ValueObjects.SimCard simCard)
        {
            View.UnlinkButton.Click();
            simCard.TerminalId = "";            
        }
    }
}