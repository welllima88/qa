using Six.Scs.Test.UI.Terminal;
using Six.Scs.Test.UI.Terminal.Dashboard.Portlets;
using Six.Scs.Test.UI.Terminal.Duplicate;
using Six.Scs.Test.Workflow.Builder;
using Location = Six.Scs.Test.Model.Location;
using TerminalDuplicate = Six.Scs.Test.Model.TerminalDuplicate;
using TerminalReplace = Six.Scs.Test.Model.TerminalReplace;

namespace Six.Scs.Test.Workflow
{
    public class Terminal
    {
        public static void Duplicate(TerminalDuplicate duplicate)
        {
            SalesContract.TerminalDuplicate.Click();

            // TerminalDuplicate.Location = "";
            View.NumberOfTerminals = duplicate.NumberOfTerminals;
            // TerminalDuplicate.DeliveryDate = "2";
            // TerminalDuplicate.InstallationType = "2";
            View.InstallationMessage = duplicate.InstallMessage;
            View.InformationText = duplicate.InformationText;
            View.CopyPassword = duplicate.CopyPassword;
            // View.Terminal.Duplicate.View.MessageForAcquirers = duplicate.MessageForAcquirers;

            View.Next.Click();
            View.DulpicateButton.Click();
        }

        public static string Quit(string remark)
        {
            SalesContract.Quit.Click();
            // Selenium.Terminal.Quit.TerminalQuit.State = "";
            // Selenium.Terminal.Quit.TerminalQuit.Delivery = "";
            var reason = "SYR QUIT Terminal " + remark;
            UI.Terminal.Quit.Quit.Reason = reason;
            UI.Terminal.Quit.Quit.Save();
            return reason;
        }

        public static void Assign(Model.Mpd mpd)
        {
            Technical.MpdAssign.Click();

            UI.Mpd.Assign.Primary = mpd.Id;
            UI.Mpd.Assign.Secondary = mpd.Id;

            UI.Mpd.Assign.SaveButton.Click();
        }

        public static void Replace(TerminalReplace replace)
        {
            SalesContract.Replace.Click();

            ArticleChooser.Select = replace.Article;

            UI.Terminal.Replace.InstallationType = replace.InstallationType;
            UI.Terminal.Replace.SalesContract = replace.SalesContract;
            UI.Terminal.Replace.SupportContract = replace.SupportContract;
            UI.Terminal.Replace.Contactless = replace.Contactless;
            UI.Terminal.Replace.DeliveryDate = replace.DeliveryDate;
            UI.Terminal.Replace.InstallationRemark = replace.InstallationRemark;
            UI.Terminal.Replace.Infotext = replace.Infotext;
            UI.Terminal.Replace.SendNotifiaction = replace.SendNotifiaction;

            UI.Terminal.Replace.SaveButton.Click();

            UI.Terminal.Replace.SaveButton.Click(); // TODO: ContactlessCapabilities save without any changes
        }

        public static void SoftwareChange()
        {
            UI.Terminal.SoftwareChange.NewSoftware = "";
            UI.Terminal.SoftwareChange.NotBefore = "";
            UI.Terminal.SoftwareChange.Save.Click();
        }

        public static void BlockSoftwareChange()
        {
            UI.Terminal.SoftwareChange.Block.Click();
        }

        public static void UnBlockSoftwareChange()
        {
            UI.Terminal.SoftwareChange.UnBlock.Click();
        }

        public static void Move(Location location)
        {
            BusinessViewpoint.MoveTerminal.Click();

            // Selenium.Terminal.Move.SelectLocation(location.CompanyName);
            UI.Terminal.Move.UpdateReceipt = true;

            UI.Terminal.Move.SaveButton.Click();
        }

        public static Model.Terminal Create(TerminalBuilder terminalBuilder)
        {
            terminalBuilder.Create();

            return terminalBuilder.Terminal;
        }

        public static void Return()
        {
            SalesContract.MarkAsRetour.Click();
        }
    }
}