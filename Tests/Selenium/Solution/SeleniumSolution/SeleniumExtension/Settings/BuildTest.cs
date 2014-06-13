using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SIX.SCS.Tests.Selenium.Extension.Settings
{
    [TestClass]
    [Ignore]
    public class BuildTest
    {
        [TestCategory("BuildTestFailed")]
        [TestMethod]
        public void BuildTestFailed()
        {
            Assert.Fail("Always fails this test :-(");
        }

        [TestCategory("BuildTestPassed")]
        [TestMethod]
        public void BuildTestPassed()
        {
            Assert.IsTrue(true, "Always pass this test :-)");
        }
    }
}