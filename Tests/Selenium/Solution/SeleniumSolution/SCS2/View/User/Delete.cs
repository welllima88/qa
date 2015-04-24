using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.View.User
{
    public class Delete : WebObject
    {
        public static IWebElementAdapter ConfirmButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("delete")); }
        }

        public static IWebElementAdapter Description
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content div.row div p")); }
        }
    }
}