using Six.Scs.QA.Selenium.Extension.TestData.Factory;
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

        public static void Duplicate()
        {
            SalesContractPortlet.TerminalDuplicate.Click();

            // TerminalDuplicate.Location = "";
            TerminalDuplicate.NumberOfTerminals = "2";
            // TerminalDuplicate.DeliveryDate = "2";
            // TerminalDuplicate.InstallationType = "2";
            TerminalDuplicate.InstallationMessage = "SYR Install Message" + Factory.GenerateTestId();
            TerminalDuplicate.InformationText = "SYR Infotext" + Factory.GenerateTestId();
            TerminalDuplicate.CopyPassword = true;
            TerminalDuplicate.MessageForAcquirers = true;
            
            TerminalDuplicate.DulpicateButton.Click();
        }
    }

    public class TerminalFactory
    {
    }

    public class TerminalData
    {
    }
}