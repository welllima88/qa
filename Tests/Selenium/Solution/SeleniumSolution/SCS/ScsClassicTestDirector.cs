using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login.LoginMethod;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics
{
    public class ScsClassicTestDirector : TestDirector
    {
        public override IWebDriverAdapter DefaultTestSetup()
        {
            var certificateLogin = new CertificateLogin(Resources.mandant_qa_L, WebDriver);
            var application = new Scs(WebDriver);

            TestSetup(Resources.WES_QA_L, certificateLogin, application,
                      application, certificateLogin);
            return WebDriver;
        }
    }
}