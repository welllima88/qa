using NUnit.Framework;
using Six.Scs.QA.Selenium.Administration.SimCard;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Testlogic;

namespace Six.Scs.QA.Selenium.SmokeTest.SIMCard
{
    [TestFixture]
    public class SimCardCreateTest
    {
        [SetUp]
        public void TestInit()
        {
            TestDirector.Navigate();
        }

        [Test]
        public void CreateSimCardAndSave()
        {
            SimCard.Create();

            Assert.IsTrue(SimCardHistory.HistoryList.Count == 1);
            // "13.12.2012 15:49:27 tksyr SIM-Karte erfasst"
            StringAssert.IsMatch(TestRegExpPatterns.DateTime + ".*"+
                                 "SIM-Karte manuell erfasst", SimCardHistory.HistoryList[0]);
        }
    }
}