using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Mpd
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
            Workflow.Mpd.Create(_mpd);
        }

        [TestMethod]
        public void Mpd()
        {
            Testlogic.Mpd.Check(_mpd);
        }
    }
}