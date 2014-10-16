using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Selenium.Terminal.Duplicate;
using Six.Scs.QA.TestData.Factory;
using TerminalDuplicate = Six.Scs.QA.TestData.ValueObjects.TerminalDuplicate;
using TerminalReplace = Six.Scs.QA.TestData.ValueObjects.TerminalReplace;

namespace Six.Scs.QA.Workflow
{
    public class Terminal
    {
        /// <summary>
        ///     Using a builder to create and configure a terminal. (This approach differs from the easier objects due to the fact
        ///     it requires more flexibility)
        /// </summary>
        /// <param name="terminalBuilder"></param>
        public static void Create(TerminalBuilder terminalBuilder)
        {
            terminalBuilder.ChooseArticle();
            terminalBuilder.SetBasics();
            terminalBuilder.SetDetails();
        }

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
            string reason = "SYR quit terminal " + Factory.GenerateTestId();
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

            ArticleChooser.Article = replace.Article;

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

        public static void ArticleChange(string article)
        {
            BusinessViewpoint.ArticleChange.Click();

            ArticleChooser.Article = article;
            Selenium.Terminal.ArticleChange.Change.Click();
            ArticleChooser.Article = article;

            Selenium.Terminal.ArticleChange.Save.Click();
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

            Selenium.Terminal.Move.SelectLocation(location.CompanyName);
            Selenium.Terminal.Move.UpdateReceipt = true;

            Selenium.Terminal.Move.SaveButton.Click();
        }
    }
}