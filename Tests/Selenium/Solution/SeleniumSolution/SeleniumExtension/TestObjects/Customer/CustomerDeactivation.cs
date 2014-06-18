using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Customer
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

        public static IWebElementAdapter Message
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lblCustomerDeleteInfo"));
            }
        }

        public static IWebElementAdapter DeactivateConfirm
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_processButton"));
            }
        }
    }
}