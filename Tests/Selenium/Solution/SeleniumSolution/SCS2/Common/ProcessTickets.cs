using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class ProcessTickets : WebObject
    {
        public static IWebElement Oldest
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.ProcessTickets_Oldest)); }
        }

        public static IWebElement Newest
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.ProcessTickets_Newest)); }
        }

        public static IWebElement Container
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.ProcessTickets_Container)); }
        }
    }
}