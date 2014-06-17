using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.SearchResult
{
    public class CustomerResult : WebObject
    {
        public static IWebElement Result()
        {
            IWebElement element =
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "div#customerDiv tbody#customerResult tr td a#customerLink[href*='/Customer/?CustomerId=']"));
            return element;
        }
    }
}