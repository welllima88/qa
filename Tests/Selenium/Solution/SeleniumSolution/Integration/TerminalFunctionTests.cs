using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSClassics;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Administration;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal;

namespace SIX.SCS.QA.Selenium.Tests.Integration
{
    /// <summary>
    /// Summary description for TerminalFunctionTests
    /// </summary>
    [TestClass]
    public class TerminalFunctionTests
    {
        private static TestDirector _scs;
        private static TestDirector _zebra;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>8
        public TestContext TestContext { get; set; }

        #region Additional test attributes

        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext)
        {
            _zebra = new ScsPlatinTestDirector();
            _scs = new ScsTestDirector();
        }

        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
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

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestMethod]
        public void YomaniDefaultFktCreateTerminalShortCut()
        {
            var terminalFunctionsAdmin = new TerminalFunctions(_scs.WebDriver);
            _scs.WebDriver.Url = _scs.BaseUrl +
                                 "/DefaultFunctions.asp?caller=SoftwareId&mode=show&SoftwareId=1085&CategoryCode=0";
            
            var terminalCreate = new TerminalCreate(_zebra.WebDriver);
            _zebra.WebDriver.Url = _zebra.BaseUrl +
                                   "Pages/Terminal/TerminalNewDetails.aspx?CustomerId=123321&LocationId=&ArticleId=D988260F-C9EC-4067-9CBE-27A48A3B4397";

            terminalCreate.TerminalConfigCreate.ContinueButton.Click();

            Assert.AreEqual(terminalCreate.TerminalConfigDetailsCreate.Article, "yomani AUTONOM, TCP/IP ep2 (IP)");

            terminalCreate.TerminalConfigDetailsCreate.Functionbits.Booking.Click();
        }
    }
}