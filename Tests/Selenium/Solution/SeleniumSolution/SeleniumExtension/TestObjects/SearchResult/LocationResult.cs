using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.SearchResult
{
    public class LocationResult : WebObject
    {
        public static IWebElement Result()
        {
            return
                WebDriver.FindElement(
                    By.CssSelector("div#locationDiv tbody#locationResult tr td a#locationLink[href*='/Location/']"));
        }
    }
}