using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Mpd
{
    public class MpdView : WebObject
    {
        public static string Id
        {
            get {return WebDriver.FindAdaptedElement(By.CssSelector("p#mpdId")).Text; }
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
    }
}