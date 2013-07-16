using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.Tests
{
    /// <summary>
    ///     Summary description for UnitTest
    /// </summary>
    [TestClass]
    public class SanityCheck
    {
        private static TestDirector _testDirector;

        /// <summary>
        ///     Gets or sets the test context which provides
        ///     information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes

        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext)
        {
            _testDirector = new ScsClassicTestDirector();

            // var auth = new UacAuthentication("six_scs_auto", "six_scs_auto_pw",_driver);
            // var auth = new CertificateAuthentication("tkcposl", _driver);
            // var app = new Scs(_driver);

            //_testDirector.SetupTest("https://gateint.telekurs.ch/scsc-qa-l/", auth, app, app, auth);
            _testDirector.PrepareBrowser();
        }

        //
        // Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup]
        public static void MyClassCleanup()
        {
            _testDirector.ShutDownBrowser();
        }

        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //

        #endregion

        [TestMethod]
        public void CheckWesAvailable()
        {
            // TODO
        }
    }
}