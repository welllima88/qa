using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Help
{
    public class HelpNavigation : WebObject
    {
        public static IWebElement Scs
        {
            get { return WebDriver.FindElement(By.CssSelector("body#frontpage div.navbar ul.nav li a[href$='/help/SCS']")); }
        }

        public static IWebElement Scs2
        {
            get { return WebDriver.FindElement(By.CssSelector("body#frontpage div.navbar ul.nav li a[href$='/help/SCS2']")); }
        }

        public static IWebElement Help
        {
            get { return WebDriver.FindElement(By.CssSelector("body#frontpage div.navbar div.navbar-inner div.container div.nav-collapse ul.nav li a[href$='/help']")); }
        }
    }
}