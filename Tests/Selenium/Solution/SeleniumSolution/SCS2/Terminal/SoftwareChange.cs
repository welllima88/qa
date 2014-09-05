using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal
{
    public class SoftwareChange : WebObject
    {
        public static string NewSoftware { get; set; }
        public static string NotBefore { get; set; }
        public static IWebElementAdapter Save { get; private set; }

        public static IWebElementAdapter Block
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Block")); }
        }

        public static IWebElementAdapter UnBlock
        {
            get { return WebDriver.FindAdaptedElement(By.Id("UnBlock")); }
        }
    }
}