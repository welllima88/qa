using Six.Scs.Test.UI.Administration.SimCard;

namespace Six.Scs.Test.Workflow
{
    public class SimCard
    {
        public static void Create(Model.SimCard simCard)
        {
            View.CreateButton.Click();

            UI.Administration.SimCard.Create.NetProvider = simCard.NetProvider;
            UI.Administration.SimCard.Create.SimCardNumber = simCard.SimCardNumber;
            UI.Administration.SimCard.Create.MobileNumber = simCard.MobileNumber;
            UI.Administration.SimCard.Create.Pin = simCard.Pin;
            UI.Administration.SimCard.Create.Puk = simCard.Puk;
            UI.Administration.SimCard.Create.Region = simCard.Region;

            UI.Administration.SimCard.Create.SaveButton.Click();
        }

        public static void Edit(Model.SimCard simCard)
        {
            View.EditButton.Click();

            UI.Administration.SimCard.Edit.NetProvider = simCard.NetProvider;
            UI.Administration.SimCard.Edit.SimCardNumber = simCard.SimCardNumber;
            UI.Administration.SimCard.Edit.MobileNumber = simCard.MobileNumber;
            UI.Administration.SimCard.Edit.Pin = simCard.Pin;
            UI.Administration.SimCard.Edit.Puk = simCard.Puk;
            UI.Administration.SimCard.Edit.Region = simCard.Region;
            UI.Administration.SimCard.Edit.Status = simCard.Status;
            UI.Administration.SimCard.Edit.TerminalId = simCard.TerminalId;
            UI.Administration.SimCard.Edit.Region = simCard.Region;
            UI.Administration.SimCard.Edit.Usage = simCard.Usage;

            UI.Administration.SimCard.Edit.SaveButton.Click();
        }

        public static void Lock(Model.SimCard sim)
        {
            View.LockButton.Click();
            sim.Status = false;
        }

        public static void Unlink(Model.SimCard simCard)
        {
            View.UnlinkButton.Click();
            simCard.TerminalId = "";
        }
    }
}