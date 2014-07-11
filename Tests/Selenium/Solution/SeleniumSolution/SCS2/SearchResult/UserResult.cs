using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.SearchResult
{
    public class UserResult : SearchResults
    {
        public UserResult()
        {
            Prefix = "div#userDiv ";
        }

        public static IWebElementAdapter First()
        {
            IWebElementAdapter element =
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        "div#userDiv tbody#userResult tr td a#userLink[href*='/User/Index?UserName=']"));
            return element;
        }
    }
}