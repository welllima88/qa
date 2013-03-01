using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login.LoginMethod;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics
{
    public class ScsClassicTestDirector : TestDirector
    {
        public override IWebDriverAdapter DefaultTestSetup()
        {
            var certificateLogin = new CertificateLogin("tkcposl", WebDriver);
            var application = new Scs(WebDriver);

            TestSetup("https://gateint.telekurs.ch/scsc-qa-l", certificateLogin, application,
                      application, certificateLogin);
            return WebDriver;
        }
    }
}