using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Location.BillingAddress
{
    public class List : WebObject
    {
        public static IWebElement BillingAdressCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("a[href*='/Merchant/BillingAddress/New?CustomerId=']"));
            }
        }
    }
}