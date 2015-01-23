using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Selenium.Terminal.Duplicate;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.Workflow.Builder;
using TerminalDuplicate = Six.Scs.QA.TestData.ValueObjects.TerminalDuplicate;
using TerminalReplace = Six.Scs.QA.TestData.ValueObjects.TerminalReplace;

namespace Six.Scs.QA.Workflow
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
            View.MessageForAcquirers = duplicate.MessageForAcquirers;

            View.DulpicateButton.Click();
        }

        public static string Quit()
        {
            SalesContract.Quit.Click();
            // Selenium.Terminal.Quit.TerminalQuit.State = "";
            // Selenium.Terminal.Quit.TerminalQuit.Delivery = "";
            string reason = "SYR QUIT Terminal " + Factory.GenerateTestId();
            Selenium.Terminal.Quit.Quit.Reason = reason;
            Selenium.Terminal.Quit.Quit.Save.Click();
            return reason;
        }

        public static void Assign(TestData.ValueObjects.Mpd mpd)
        {
            TechnicalView.MpdAssign.Click();

            Selenium.Mpd.Assign.Primary = mpd.Id;
            Selenium.Mpd.Assign.Secondary = mpd.Id;

            Selenium.Mpd.Assign.SaveButton.Click();
        }

        public static void Replace(TerminalReplace replace)
        {
            SalesContract.Replace.Click();

            ArticleChooser.Select = replace.Article;

            Selenium.Terminal.Replace.InstallationType = replace.InstallationType;
            Selenium.Terminal.Replace.SalesContract = replace.SalesContract;
            Selenium.Terminal.Replace.SupportContract = replace.SupportContract;
            Selenium.Terminal.Replace.Contactless = replace.Contactless;
            Selenium.Terminal.Replace.DeliveryDate = replace.DeliveryDate;
            Selenium.Terminal.Replace.InstallationRemark = replace.InstallationRemark;
            Selenium.Terminal.Replace.Infotext = replace.Infotext;
            Selenium.Terminal.Replace.SendNotifiaction = replace.SendNotifiaction;

            Selenium.Terminal.Replace.SaveButton.Click();
        }

        public static void SoftwareChange()
        {
            Selenium.Terminal.SoftwareChange.NewSoftware = "";
            Selenium.Terminal.SoftwareChange.NotBefore = "";
            Selenium.Terminal.SoftwareChange.Save.Click();
        }

        public static void BlockSoftwareChange()
        {
            Selenium.Terminal.SoftwareChange.Block.Click();
        }

        public static void UnBlockSoftwareChange()
        {
            Selenium.Terminal.SoftwareChange.UnBlock.Click();
        }

        public static void Move(TestData.ValueObjects.Location location)
        {
            BusinessViewpoint.MoveTerminal.Click();

            // Selenium.Terminal.Move.SelectLocation(location.CompanyName);
            Selenium.Terminal.Move.UpdateReceipt = true;

            Selenium.Terminal.Move.SaveButton.Click();
        }

        public static TestData.ValueObjects.Terminal Create(TerminalBuilder terminalBuilder)
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