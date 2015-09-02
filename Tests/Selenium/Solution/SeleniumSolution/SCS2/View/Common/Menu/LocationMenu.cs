using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Common.Menu
{
    public class LocationMenu : WebObject
    {
        public static IWebElement Location
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/Location/?LOCATIONID=']"));
            }
        }

        public static IWebElement CreateInfotext
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/InfoText/NewLocationInfoText']"));
            }
        }

        public static IWebElement LocationQuit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='Location.asp?mode=Cancel&LocationFunction=']"));
            }
        }

        public static IWebElement Terminals
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/Location/TerminalList?LOCATIONID=']"));
            }
        }

        public static IWebElement Contacts
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/Person/LocationPersonList'][href*='&LOCATIONID=']"));
            }
        }
    }
}