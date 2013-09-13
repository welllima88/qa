using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal.Dashboard
{
    /// <summary>
    ///     This object bundles the fix view elements of the "Terminal Dashboard"
    /// </summary>
    public class FixInfo : WebObject
    {
        public readonly CustomerInfo Customer;
        public readonly LocationInfo Location;
        public readonly TerminalInfo Terminal;

        public FixInfo()
        {
            Prefix = "";
            Customer = new CustomerInfo();
            Location = new LocationInfo();
            Terminal = new TerminalInfo();
        }
    }
}