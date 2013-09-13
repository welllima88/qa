using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal
{
    public class TerminalCreate : WebObject
    {
        public TerminalChooser TerminalChooser;
        public TerminalConfigCreate TerminalConfigCreate;
        public TerminalConfigDetailsCreate TerminalConfigDetailsCreate;

        public TerminalCreate()
        {
            TerminalChooser = new TerminalChooser();
            TerminalConfigCreate = new TerminalConfigCreate();
            TerminalConfigDetailsCreate = new TerminalConfigDetailsCreate();
        }
    }
}