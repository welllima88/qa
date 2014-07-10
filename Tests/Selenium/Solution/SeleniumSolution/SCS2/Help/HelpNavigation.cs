using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Help
{
    public class HelpNavigation : WebObject
    {
        public static IWebElement Scs
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("body#frontpage div.navbar ul.nav li a[href$='/help/SCS']"));
            }
        }

        public static IWebElement Scs2
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("body#frontpage div.navbar ul.nav li a[href$='/help/SCS2']"));
            }
        }

        public static IWebElement Help
        {
            get
            {
                return WebDriver.FindElement(By.CssSelector("body#frontpage div.navbar ul.nav li a[href$='/help']"));
            }
        }
    }
}