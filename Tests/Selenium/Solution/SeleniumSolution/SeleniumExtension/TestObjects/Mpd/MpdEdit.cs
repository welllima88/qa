using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Mpd
{
    public class MpdEdit : WebObject
    {
        public static string Description
        {
            set { MpdCreate.Description = value; }
        }

        public static string Adress
        {
            set { MpdCreate.Adress = value; }
        }

        public static string Port
        {
            set { MpdCreate.Port = value; }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#save")); }
        }
    }
}