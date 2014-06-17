using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.TestData;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Definitions;
using Six.Scs.Tests.Selenium.Extension.WebDriver;
using Six.Scs.Tests.Selenium.Extension.Worklow;

namespace Six.Scs.Tests.Selenium.Tests.Mpd
{
    [TestClass]
    public class MpdCreateTest
    {
        private MpdData _mpd;

        [TestMethod]
        public void CreateMpdToCustomer()
        {
            TestDirector.Navigate("Mpd/ListByCustomer/?CUSTOMERID=402200");
            _mpd = MpdFactory.Create();
            MpdService.Create(_mpd);
        }

        [TestMethod]
        public void Mpd()
        {
            MpdService.Check(_mpd);
        }
    }
}