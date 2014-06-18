using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    /// <summary>
    ///     This object bundles the fix view elements of the "Terminal Dashboard"
    /// </summary>
    public class TerminFixInfo : WebObject
    {
        public static readonly CustomerInfo Customer;
        public static readonly LocationInfo Location;
        public static readonly TerminalInfo Terminal;

        public TerminFixInfo()
        {
            Prefix = "";
        }
    }
}