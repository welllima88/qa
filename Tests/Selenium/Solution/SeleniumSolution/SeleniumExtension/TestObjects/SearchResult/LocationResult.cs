using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.SearchResult
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