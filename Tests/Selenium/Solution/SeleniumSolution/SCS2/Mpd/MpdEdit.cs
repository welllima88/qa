using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Mpd
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

        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#save")).Button(); }
        }
    }
}