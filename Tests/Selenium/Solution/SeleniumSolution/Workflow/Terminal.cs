using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Selenium.Terminal.Quit;
using Six.Scs.QA.TestData.Factory;
using TerminalDuplicate = Six.Scs.QA.TestData.ValueObjects.TerminalDuplicate;

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
            Selenium.Terminal.Duplicate.View.NumberOfTerminals = duplicate.NumberOfTerminals;
            // TerminalDuplicate.DeliveryDate = "2";
            // TerminalDuplicate.InstallationType = "2";
            Selenium.Terminal.Duplicate.View.InstallationMessage = duplicate.InstallMessage;
            Selenium.Terminal.Duplicate.View.InformationText = duplicate.InformationText;
            Selenium.Terminal.Duplicate.View.CopyPassword = duplicate.CopyPassword;
            Selenium.Terminal.Duplicate.View.MessageForAcquirers = duplicate.MessageForAcquirers;

            Selenium.Terminal.Duplicate.View.DulpicateButton.Click();
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
    }
}