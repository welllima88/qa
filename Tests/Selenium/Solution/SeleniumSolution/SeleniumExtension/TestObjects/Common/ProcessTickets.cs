using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class ProcessTickets : WebObject
    {
        public IWebElement Oldest
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.ProcessTickets_Oldest)); }
        }

        public IWebElement Newest
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.ProcessTickets_Newest)); }
        }

        public IWebElement Container
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.ProcessTickets_Container)); }
        }
    }
}