using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Help
{
    public class Navigation : WebObject
    {
        public static IWebElementAdapter ReleaseNotes
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("body div ul.nav li a[href$='/help/Releasenotes']"));
            }
        }

        public static IWebElementAdapter Scs2
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("body div.navbar-inner div.container a.brand[href*='gate.telekurs.ch/scs2']"));
            }
        }

        public static IWebElementAdapter ScsHelp
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("body div ul.nav li a[href$='/help/SCS2']")); }
        }
    }
}