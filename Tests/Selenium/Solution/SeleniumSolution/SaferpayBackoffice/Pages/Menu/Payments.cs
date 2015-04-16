using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Six.Saferpay.QA.Selenium.Pages.Menu
{
    public class Payments
    {
        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href*='/Commerce/JournalOverview?CSRFToken=']")]
        public IWebElement Booking;

        [FindsBy(How = How.CssSelector, Using = "div#menu li a[href*='/Commerce/Payment/Capture?CSRFToken=']")]
        public IWebElement Journal;
    }
}