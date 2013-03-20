using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class TerminalTextsPortlet : PortletViewBase
    {
        public TerminalTextsPortlet(IWebDriverAdapter driver) : base(driver)
        {
            PortletId = "div#frame_TerminalInfotextPortlet";
        }
    }
}