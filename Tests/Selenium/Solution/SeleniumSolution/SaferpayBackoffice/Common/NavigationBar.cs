using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Saferpay.QA.Selenium.Common
{
    public class NavigationBar : WebObject
    {
        public static IWebElementAdapter MySaferpay
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("li#topic_home"));
            }
        }

        public static IWebElementAdapter OnlineSupport
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("li#topic_support"));
            }
        }
    }
}