using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;
using Six.Scs.QA.Selenium.Extension.Worklow;

namespace Six.Scs.QA.Selenium.Extension.TestData.Factory
{
    public class TerminalDuplicateDataFactory
    {
        public static TerminalDuplicateData Create()
        {
            return new TerminalDuplicateData
            {
                NumberOfTerminals = "2",
                InstallMessage = "SYR Install Message " + Factory.GenerateTestId(),
                InformationText = "SYR Infotext " + Factory.GenerateTestId(),
                CopyPassword = true,
                MessageForAcquirers = true
            };
        }
    }
}