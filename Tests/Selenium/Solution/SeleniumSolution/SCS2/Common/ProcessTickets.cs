using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class ProcessTickets : WebObject
    {
        public static IWebElementAdapter Oldest
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.ProcessTickets_Oldest)); }
        }

        public static IWebElementAdapter Newest
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.ProcessTickets_Newest)); }
        }

        public static IWebElementAdapter Container
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.ProcessTickets_Container)); }
        }
    }
}