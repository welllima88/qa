using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Mpd
{
    public class View : WebObject
    {
        public static string Id
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("p#mpdId")).Text; }
        }

        public static string Description
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("p#mpdDescription")).Text; }
        }

        public static string Adress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("p#InetAddr")).Text; }
        }

        public static string Port
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("p#InetPort")).Text; }
        }

        public static ButtonElement EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#edit")).Button(); }
        }
    }
}