using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
{
    public class TerminalCreate : WebObject
    {
        public TerminalChooser TerminalChooser;
        public TerminalConfigCreate TerminalConfigCreate;
        public TerminalConfigDetailsCreate TerminalConfigDetailsCreate;

        public TerminalCreate(IWebDriverAdapter driver) : base(driver)
        {
            TerminalChooser = new TerminalChooser(Driver);
            TerminalConfigCreate = new TerminalConfigCreate(Driver);
            TerminalConfigDetailsCreate = new TerminalConfigDetailsCreate(Driver);
        }
    }
}