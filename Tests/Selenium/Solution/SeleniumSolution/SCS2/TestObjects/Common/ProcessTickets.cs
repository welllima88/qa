using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class ProcessTickets : WebObject
    {
        public ProcessTickets(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement Oldest
        {
            get { return Driver.FindElement(By.CssSelector(Common.ProcessTickets_Oldest)); }
        }

        public IWebElement Newest
        {
            get { return Driver.FindElement(By.CssSelector(Common.ProcessTickets_Newest)); }
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(By.CssSelector(Common.ProcessTickets_Container)); }
        }
    }
}