using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Customer
{
    public class Deactivate : WebObject
    {
        public static ButtonElement Cancel
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lblCustomerDeleteInfo"))
                        .Button();
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