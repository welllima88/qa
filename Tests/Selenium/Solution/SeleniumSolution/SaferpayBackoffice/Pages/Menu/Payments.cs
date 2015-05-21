using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Six.Saferpay.Backoffice.Test.Pages.Menu
{
    public class Payments
    {
        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href*='/Commerce/JournalOverview?CSRFToken=']")]
        public IWebElement Booking;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href*='/Commerce/Payment/Capture?CSRFToken=']")]
        public IWebElement Journal;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href*='/Commerce/Payment/Authorize']")]
        public IWebElement Reservation;
    }
}