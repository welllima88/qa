using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Terminal
{
    public class SoftwareChange : WebObject
    {
        public static string NewSoftware { get; set; }
        public static string NotBefore { get; set; }
        public static IWebElement Save { get; private set; }

        public static IWebElement Block
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Block")); }
        }

        public static IWebElement UnBlock
        {
            get { return WebDriver.FindAdaptedElement(By.Id("UnBlock")); }
        }

        public static IWebElement Cancel
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content a.btn-default")); }
        }
    }
}