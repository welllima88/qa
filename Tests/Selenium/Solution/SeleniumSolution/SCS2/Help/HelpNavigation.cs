using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Help
{
    public class HelpNavigation : WebObject
    {
        public static IWebElementAdapter Scs
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("body#frontpage div.navbar ul.nav li a[href$='/help/SCS']"));
            }
        }

        public static IWebElementAdapter Scs2
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("body#frontpage div.navbar ul.nav li a[href$='/help/SCS2']"));
            }
        }

        public static IWebElementAdapter Help
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("body#frontpage div.navbar ul.nav li a[href$='/help']"));
            }
        }
    }
}