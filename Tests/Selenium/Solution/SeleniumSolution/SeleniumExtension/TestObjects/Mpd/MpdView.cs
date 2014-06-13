using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.Tests.Selenium.Extension.TestObjects.Mpd
{
    public class MpdView : WebObject
    {
        public static string Id
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#MpdId")).Text; }
        }

        public static string Description
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#Description")).Text; }
        }

        public static string Adress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#InetAddr")).Text; }
        }

        public static string Port
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#InetPort")).Text; }
        }
    }
}