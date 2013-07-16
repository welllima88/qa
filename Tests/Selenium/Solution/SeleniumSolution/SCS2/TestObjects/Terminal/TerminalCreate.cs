using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
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