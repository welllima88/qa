using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Location.BillingAddress
{
    public class List : WebObject
    {
        public static IWebElementAdapter BillingAdressCreate
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