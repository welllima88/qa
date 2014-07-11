using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Customer
{
    public class CustomerDeactivation : WebObject
    {
        public static ButtonElement Cancel
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lblCustomerDeleteInfo")).Button();
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