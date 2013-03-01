using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login.LoginMethod;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Login;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin
{
    public class ScsPlatinTestDirector : TestDirector
    {
        public ScsPlatinTestDirector(string p) : base(p)
        {
        }

        public ScsPlatinTestDirector()
        {
        }

        public override IWebDriverAdapter DefaultTestSetup()
        {
            var certificateLogin = new CertificateLogin("tkcposl", WebDriver);
            var lobby = new Lobby(WebDriver);
            
            TestSetup("https://gateint.telekurs.ch/zebrac-qa-l", certificateLogin, lobby);
            return WebDriver;
        }
    }
}