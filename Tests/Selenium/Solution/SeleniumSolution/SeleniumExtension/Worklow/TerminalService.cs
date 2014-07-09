using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;
using Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;
using Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.Duplicate;

namespace Six.Scs.QA.Selenium.Extension.Worklow
{
    public class TerminalService
    {
        public static void Create(TerminalData terminalData)
        {
        }

        public static void Check(TerminalData terminalData)
        {
            // DB Check Terminal and Contracts?
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