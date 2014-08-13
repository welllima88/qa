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
            Selenium.Terminal.Duplicate.TerminalDuplicate.NumberOfTerminals = duplicate.NumberOfTerminals;
            // TerminalDuplicate.DeliveryDate = "2";
            // TerminalDuplicate.InstallationType = "2";
            Selenium.Terminal.Duplicate.TerminalDuplicate.InstallationMessage = duplicate.InstallMessage;
            Selenium.Terminal.Duplicate.TerminalDuplicate.InformationText = duplicate.InformationText;
            Selenium.Terminal.Duplicate.TerminalDuplicate.CopyPassword = duplicate.CopyPassword;
            Selenium.Terminal.Duplicate.TerminalDuplicate.MessageForAcquirers = duplicate.MessageForAcquirers;

            Selenium.Terminal.Duplicate.TerminalDuplicate.DulpicateButton.Click();
        }

        public static string Quit()
        {
            SalesContract.Quit.Click();
            // Selenium.Terminal.Quit.TerminalQuit.State = "";
            // Selenium.Terminal.Quit.TerminalQuit.Delivery = "";
            string reason = "SYR quit terminal " + Factory.GenerateTestId();
            TerminalQuit.Reason = reason;
            TerminalQuit.Save.Click();
            return reason;
        }
    }
}