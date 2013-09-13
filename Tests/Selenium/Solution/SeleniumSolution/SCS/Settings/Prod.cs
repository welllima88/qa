using SIX.SCS.QA.SCSClassics.Tests.Selenium.Properties;
using SIX.SCS.QA.SCSClassics.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;

namespace SIX.SCS.QA.SCSClassics.Tests.Selenium.Settings
{
    public class Prod : TestEnvironment
    {
        public Prod()
        {
            BaseUrl = ScsRes.WES_Production;
            BrowserProfileName = DriverRes.FirefoxProfile_Plain;
            Application = new Scs();
            Authentication = new SecurIdDialogBox();
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }
    }
}