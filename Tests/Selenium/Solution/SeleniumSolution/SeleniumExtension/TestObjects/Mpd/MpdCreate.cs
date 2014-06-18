using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Mpd
{
    public class MpdCreate : WebObject
    {
        public static string Description
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Description")).TextBox().TypeText(value); }
        }

        public static string Adress
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#InetAddr")).TextBox().TypeText(value); }
        }

        public static string Port
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#InetPort")).TextBox().TypeText(value); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#save")); }
        }
    }
}