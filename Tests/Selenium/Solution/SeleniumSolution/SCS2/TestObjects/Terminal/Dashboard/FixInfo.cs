using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class FixInfo : PortletViewBase
    {
        public readonly CustomerInfo Customer;
        public readonly LocationInfo Location;
        public readonly TerminalInfo Terminal;

        public FixInfo(IWebDriverAdapter webDriver) : base(webDriver)
        {
            Customer = new CustomerInfo(webDriver);
            Location = new LocationInfo(webDriver);
            Terminal = new TerminalInfo(webDriver);
        }
    }
}