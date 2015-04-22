using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Saferpay.QA.Selenium.Pages.Menu;

namespace Six.Saferpay.QA.Selenium.Tests.Payment
{
    [TestFixture]
    public class Booking
    {
        [TestFixtureSetUp]
        public void GoToBooking()
        {
            TestDirector.Navigate();
            Menu.Home().MySaferpay.SecurePayGate.Click();
            Menu.Home().Payments.Booking.Click();
        }

        [Test]
        public void CreateBooking()
        {
        }
    }
}