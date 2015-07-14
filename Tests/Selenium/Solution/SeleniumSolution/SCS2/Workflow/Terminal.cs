using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.View.Terminal;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Builder;
using TerminalDuplicate = Six.Scs.Test.Model.ValueObjects.TerminalDuplicate;
using TerminalReplace = Six.Scs.Test.Model.ValueObjects.TerminalReplace;

namespace Six.Scs.Test.Workflow
{
    public class Terminal
    {
        public static void Duplicate(TerminalDuplicate duplicate)
        {
            SalesContract.TerminalDuplicate.Click();

            // TerminalDuplicate.Location = "";
            View.Terminal.Duplicate.View.NumberOfTerminals = duplicate.NumberOfTerminals;
            // TerminalDuplicate.DeliveryDate = "2";
            // TerminalDuplicate.InstallationType = "2";
            View.Terminal.Duplicate.View.InstallationMessage = duplicate.InstallMessage;
            View.Terminal.Duplicate.View.InformationText = duplicate.InformationText;
            View.Terminal.Duplicate.View.CopyPassword = duplicate.CopyPassword;
            View.Terminal.Duplicate.View.MessageForAcquirers = duplicate.MessageForAcquirers;

            View.Terminal.Duplicate.View.Next.Click();
            View.Terminal.Duplicate.View.DulpicateButton.Click();

            View.Massmuation.TerminalValidation.ExecuteButton.Click();
        }

        public static string Quit()
        {
            SalesContract.Quit.Click();
            // Selenium.Terminal.Quit.TerminalQuit.State = "";
            // Selenium.Terminal.Quit.TerminalQuit.Delivery = "";
            var reason = "SYR QUIT Terminal " + Factory.GenerateTestId();
            View.Terminal.Quit.Quit.Reason = reason;
            View.Terminal.Quit.Quit.Save();
            return reason;
        }

        public static void Assign(Model.ValueObjects.Mpd mpd)
        {
            TechnicalView.MpdAssign.Click();

            View.Mpd.Assign.Primary = mpd.Id;
            View.Mpd.Assign.Secondary = mpd.Id;

            View.Mpd.Assign.SaveButton.Click();
        }

        public static void Replace(TerminalReplace replace)
        {
            SalesContract.Replace.Click();

            ArticleChooser.Select = replace.Article;

            View.Terminal.Replace.InstallationType = replace.InstallationType;
            View.Terminal.Replace.SalesContract = replace.SalesContract;
            View.Terminal.Replace.SupportContract = replace.SupportContract;
            View.Terminal.Replace.Contactless = replace.Contactless;
            View.Terminal.Replace.DeliveryDate = replace.DeliveryDate;
            View.Terminal.Replace.InstallationRemark = replace.InstallationRemark;
            View.Terminal.Replace.Infotext = replace.Infotext;
            View.Terminal.Replace.SendNotifiaction = replace.SendNotifiaction;

            View.Terminal.Replace.SaveButton.Click();

            View.Terminal.Replace.SaveButton.Click(); // TODO: ContactlessCapabilities save without any changes
        }

        public static void SoftwareChange()
        {
            View.Terminal.SoftwareChange.NewSoftware = "";
            View.Terminal.SoftwareChange.NotBefore = "";
            View.Terminal.SoftwareChange.Save.Click();
        }

        public static void BlockSoftwareChange()
        {
            View.Terminal.SoftwareChange.Block.Click();
        }

        public static void UnBlockSoftwareChange()
        {
            View.Terminal.SoftwareChange.UnBlock.Click();
        }

        public static void Move(Model.ValueObjects.Location location)
        {
            BusinessViewpoint.MoveTerminal.Click();

            // Selenium.Terminal.Move.SelectLocation(location.CompanyName);
            View.Terminal.Move.UpdateReceipt = true;

            View.Terminal.Move.SaveButton.Click();
        }

        public static Model.ValueObjects.Terminal Create(TerminalBuilder terminalBuilder)
        {
            terminalBuilder.Create();

            return terminalBuilder.Terminal;
        }

        public static void Retour()
        {
            SalesContract.MarkAsRetour.Click();
        }
    }
}