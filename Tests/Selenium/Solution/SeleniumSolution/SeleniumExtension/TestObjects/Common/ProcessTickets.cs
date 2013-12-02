using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
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