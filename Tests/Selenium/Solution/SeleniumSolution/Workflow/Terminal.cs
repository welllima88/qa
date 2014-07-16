using Six.Scs.QA.Selenium.Terminal.Dashboard;
using Six.Scs.QA.Selenium.Terminal.Duplicate;
using Six.Scs.QA.TestData.ValueObjects;

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

        public static void Duplicate(TerminalDuplicateData duplicateData)
        {
            SalesContractPortlet.TerminalDuplicate.Click();

            // TerminalDuplicate.Location = "";
            TerminalDuplicate.NumberOfTerminals = duplicateData.NumberOfTerminals;
            // TerminalDuplicate.DeliveryDate = "2";
            // TerminalDuplicate.InstallationType = "2";
            TerminalDuplicate.InstallationMessage = duplicateData.InstallMessage;
            TerminalDuplicate.InformationText = duplicateData.InformationText;
            TerminalDuplicate.CopyPassword = duplicateData.CopyPassword;
            TerminalDuplicate.MessageForAcquirers = duplicateData.MessageForAcquirers;

            TerminalDuplicate.DulpicateButton.Click();
        }
    }
}