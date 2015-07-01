using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Common.Menu
{
    public class LocationMenu : WebObject
    {
        public static IWebElementAdapter Location
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/Location/?LOCATIONID=']"));
            }
        }

        public static IWebElementAdapter TerminalCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "td#leftHandMenu a[href*='/TerminalArticleSelector/LocationTerminalNew/?LOCATIONID=']"));
            }
        }

        public static IWebElementAdapter CreateInfotext
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/InfoText/NewLocationInfoText']"));
            }
        }

        public static IWebElementAdapter LocationEdit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='Location/Edit?LOCATIONID=']"));
            }
        }

        public static IWebElementAdapter LocationQuit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='Location.asp?mode=Cancel&LocationFunction=']"));
            }
        }

        public static IWebElementAdapter Terminals
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/Location/TerminalList?LOCATIONID=']"));
            }
        }

        public static IWebElementAdapter Contacts
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