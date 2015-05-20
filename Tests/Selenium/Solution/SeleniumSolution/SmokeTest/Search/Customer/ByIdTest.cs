using NUnit.Framework;
using Six.Scs.Test.View.Search;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Search.Customer
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class ByIdTest
    {
        private static string _debitorNumber;

        [TestFixtureSetUp]
        [Category("Search")]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            Workflow.Search.Find("1");
            new SearchResult(Result.Customer).First().Click();
            _debitorNumber = View.Location.View.SbsDebitNumber;
        }

        [Test]
        [Category("Search"), Category("Location")]
        public void DebitorNumber()
        {
            Workflow.Search.Find(_debitorNumber);
            StringAssert.Contains("SIX Payment Services AG", new SearchResult(Result.Customer).First().Text);
            new SearchResult(Result.Customer).First().Click();
            Assert.That(_debitorNumber, Is.EqualTo(View.Location.View.SbsDebitNumber));
        }
    }
}