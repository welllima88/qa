using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestData;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension.Worklow;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Mpd
{
    [TestClass]
    public class MpdCreateTest
    {
        private MpdData _mpd;

        [TestMethod]
        public void CreateMpdToCustomer()
        {
            TestDirector.Navigate("Mpd/ListByCustomer/?CUSTOMERID=402200");
            _mpd = Factory.Mpd.Create();
            MpdService.Create(_mpd);
        }

        [TestMethod]
        public void Mpd()
        {
            MpdService.Check(_mpd);
        }
    }
}