using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult
{
    public class CustomerResult : WebObject
    {
        public static string CustomerId
        {
            get { return WebDriver.FindElement(By.CssSelector("tbody#customerResult span#customerId")).Text; }
        }

        public static IWebElement ShowDescent(string customerId)
        {
            return ShowDescents().FindElement(By.CssSelector("img[node_searchhint='" + customerId +
                                                             "'][alt='child_expanderIcon']"));
        }

        public static IWebElement ShowDescents()
        {
            return
                WebDriver.FindElement(By.CssSelector("tbody#customerResult"));
        }

        public static IWebElement Result(string s)
        {
            return ShowDescents().FindElement(By.CssSelector("a#customerLink[href*='" + s + "']"));
        }

        public static IWebElement Result()
        {
            return ShowDescents().FindElement(By.CssSelector("a#customerLink"));
        }
    }
}