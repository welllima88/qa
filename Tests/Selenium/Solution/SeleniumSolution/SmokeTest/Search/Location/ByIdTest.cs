using NUnit.Framework;
using Six.Scs.Test.View.Search;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Search.Location
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class ByIdTest
    {
        private static string _locationNumber;
        private static string _debitorNumber;
        private static string _ep2MerchantId;

        [TestFixtureSetUp]
        [Category("Search")]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            Workflow.Search.Find("TK00000100108834");
            new SearchResult(Result.Location).First().Click();

            Assert.That("TK00000100108834", Is.EqualTo(View.Location.View.Ep2MerchantId));

            _locationNumber = View.Location.View.LocationNumber;
            _debitorNumber = View.Location.View.SbsDebitNumber;
            _ep2MerchantId = View.Location.View.Ep2MerchantId;
        }

        [Test]
        [Category("Search"), Category("Location")]
        public void DebitorNumber()
        {
            Workflow.Search.Find(_debitorNumber);
            // StringAssert.Contains("SIX Payment Services AG", new SearchResult(Result.Location).First().Text);
            new SearchResult(Result.Location).First().Click();
            Assert.That(_debitorNumber, Is.EqualTo(View.Location.View.SbsDebitNumber));
            Assert.That("TK00000100108834", Is.EqualTo(View.Location.View.Ep2MerchantId));
        }

        [Test]
        [Category("Search"), Category("Location")]
        public void Ep2MerchantId()
        {
            Workflow.Search.Find(_ep2MerchantId);
            // StringAssert.Contains("SIX Payment Services AG", new SearchResult(Result.Location).First().Text);
            new SearchResult(Result.Location).First().Click();
            Assert.That(_ep2MerchantId, Is.EqualTo(View.Location.View.Ep2MerchantId));
            Assert.That("TK00000100108834", Is.EqualTo(View.Location.View.Ep2MerchantId));
        }

        [Test]
        [Category("Search"), Category("Location")]
        public void LocationNumber()
        {
            Workflow.Search.Find(_locationNumber);
            // StringAssert.Contains("SIX Payment Services AG", new SearchResult(Result.Location).First().Text);
            new SearchResult(Result.Location).First().Click();
            Assert.That(_locationNumber, Is.EqualTo(View.Location.View.LocationNumber));
            Assert.That("TK00000100108834", Is.EqualTo(View.Location.View.Ep2MerchantId));
        }
    }
}