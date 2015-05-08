using NUnit.Framework;
using Six.Saferpay.Backoffice.Test.Pages.Menu;
using Six.Test.Selenium.WebDriver;

namespace Six.Saferpay.Backoffice.Test.Tests.Payment
{
    [TestFixture]
    public class Booking
    {
        [TestFixtureSetUp]
        public void GoToBooking()
        {
            TestDirector.Navigate();
            Menu.Home().MySaferpay.Transactions.Click();
            Menu.Home().Payments.Booking.Click();
        }

        [Test]
        public void CreateBooking()
        {
        }
    }
}