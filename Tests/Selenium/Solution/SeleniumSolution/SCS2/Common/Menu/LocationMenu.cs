using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
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

        public static IWebElementAdapter ContactCreate
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='Person/New?LOCATIONID=']"));
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

        public static IWebElementAdapter Infotexts
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/InfoText/ListLocation']"));
            }
        }
    }
}