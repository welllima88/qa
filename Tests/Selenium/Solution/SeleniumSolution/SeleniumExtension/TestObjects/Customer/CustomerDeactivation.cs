using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Customer
{
    public class CustomerDeactivation : WebObject
    {
        public static IWebElementAdapter Cancel
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lblCustomerDeleteInfo"));
            }
        }

        public IWebElementAdapter Message
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lblCustomerDeleteInfo"));
            }
        }

        public IWebElementAdapter DeactivateConfirm
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_processButton"));
            }
        }
    }
}