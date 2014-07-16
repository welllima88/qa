using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.SearchResult
{
    public class MpdResult : SearchResults
    {
        public MpdResult()
        {
            Prefix = "div#mpdDiv.container ";
        }

        public static IWebElementAdapter First()
        {
            IWebElementAdapter element =
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "div#userDiv tbody#mpdResult tr td a#mpdLink[href*='/Mpd/?mpdId=']"));
            return element;
        }
    }
}