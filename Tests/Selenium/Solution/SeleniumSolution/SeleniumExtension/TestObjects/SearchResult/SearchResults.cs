using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.Tests.Selenium.Extension.TestObjects.SearchResult
{
    public class SearchResults : WebObject
    {
        /// <summary>
        ///     It is recommended to set the prefix property to the appropiate container element
        /// </summary>
        public static string Headline
        {
            get { return WebDriver.FindElement(By.CssSelector("td#content h1")).Text; }
        }

        public static IWebElement LoadMoreLink
        {
            get { return WebDriver.FindElement(By.CssSelector("span input[id^='loadMore']")); }
        }

        public static IWebElement FilterTextField
        {
            get { return WebDriver.FindElement(By.CssSelector("span input[id$='Filter']")); }
        }

        public static CustomerResult Customers()
        {
            return new CustomerResult();
        }

        public static LocationResult Locations()
        {
            return new LocationResult();
        }

        public static TerminalResult Terminals()
        {
            return new TerminalResult();
        }

        public static UserResult Users()
        {
            return new UserResult();
        }

        public static SimCardResult Simcards()
        {
            return new SimCardResult();
        }

        public static MpdResult Mpds()
        {
            return new MpdResult();
        }
    }
}