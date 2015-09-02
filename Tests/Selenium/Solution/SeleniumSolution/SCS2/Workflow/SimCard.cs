namespace Six.Scs.Test.Workflow
{
    public class SimCard
    {
        public static void Create(Model.SimCard simCard)
        {
            View.Administration.SimCard.View.CreateButton.Click();

            View.Administration.SimCard.Create.NetProvider = simCard.NetProvider;
            View.Administration.SimCard.Create.SimCardNumber = simCard.SimCardNumber;
            View.Administration.SimCard.Create.MobileNumber = simCard.MobileNumber;
            View.Administration.SimCard.Create.Pin = simCard.Pin;
            View.Administration.SimCard.Create.Puk = simCard.Puk;
            View.Administration.SimCard.Create.Region = simCard.Region;

            View.Administration.SimCard.Create.SaveButton.Click();
        }

        public static void Edit(Model.SimCard simCard)
        {
            View.Administration.SimCard.View.EditButton.Click();

            View.Administration.SimCard.Edit.NetProvider = simCard.NetProvider;
            View.Administration.SimCard.Edit.SimCardNumber = simCard.SimCardNumber;
            View.Administration.SimCard.Edit.MobileNumber = simCard.MobileNumber;
            View.Administration.SimCard.Edit.Pin = simCard.Pin;
            View.Administration.SimCard.Edit.Puk = simCard.Puk;
            View.Administration.SimCard.Edit.Region = simCard.Region;
            View.Administration.SimCard.Edit.Status = simCard.Status;
            View.Administration.SimCard.Edit.TerminalId = simCard.TerminalId;
            View.Administration.SimCard.Edit.Region = simCard.Region;
            View.Administration.SimCard.Edit.Usage = simCard.Usage;

            View.Administration.SimCard.Edit.SaveButton.Click();
        }

        public static void Lock(Model.SimCard sim)
        {
            View.Administration.SimCard.View.LockButton.Click();
            sim.Status = false;
        }

        public static void Unlink(Model.SimCard simCard)
        {
            View.Administration.SimCard.View.UnlinkButton.Click();
            simCard.TerminalId = "";
        }
    }
}