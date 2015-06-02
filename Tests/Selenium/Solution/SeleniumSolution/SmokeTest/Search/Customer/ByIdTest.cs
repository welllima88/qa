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
            SearchResult.First(Result.Customer).Click();
            _debitorNumber = View.Location.View.SbsDebitNumber;
        }

        [Test]
        [Category("Search"), Category("Location")]
        public void DebitorNumber()
        {
            Workflow.Search.Find(_debitorNumber);
            StringAssert.Contains("SIX Payment Services AG", SearchResult.First(Result.Customer).Text);
            SearchResult.First(Result.Customer).Click();
            Assert.That(_debitorNumber, Is.EqualTo(View.Location.View.SbsDebitNumber));
        }
    }
}