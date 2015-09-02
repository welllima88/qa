using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Customer
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

        public static IWebElement Message
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lblCustomerDeleteInfo"));
            }
        }

        public static IWebElement DeactivateConfirm
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_processButton"));
            }
        }
    }
}