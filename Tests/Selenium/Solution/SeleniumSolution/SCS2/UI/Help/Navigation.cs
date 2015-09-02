using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Help
{
    public class Navigation : WebObject
    {
        public static IWebElement ReleaseNotes
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("body div ul.nav li a[href$='/help/Releasenotes']"));
            }
        }

        public static IWebElement Scs2
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("body div.navbar-inner div.container a.brand[href*='gate.telekurs.ch/scs2']"));
            }
        }

        public static IWebElement ScsHelp
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("body div ul.nav li a[href$='/help/SCS2']")); }
        }
    }
}