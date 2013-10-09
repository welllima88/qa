namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal
{
    public class TerminalCreate : WebObject
    {
        public readonly TerminalChooser TerminalChooser;
        public readonly TerminalConfigCreate TerminalConfigCreate;
        public readonly TerminalConfigDetailsCreate TerminalConfigDetailsCreate;

        public TerminalCreate()
        {
            TerminalChooser = new TerminalChooser();
            TerminalConfigCreate = new TerminalConfigCreate();
            TerminalConfigDetailsCreate = new TerminalConfigDetailsCreate();
        }
    }
}