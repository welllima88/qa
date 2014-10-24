using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Mpd
{
    public class Assign : WebObject
    {
        public static string Primary
        {
            set { WebDriver.FindAdaptedElement(By.Id("PrimaryMpdSelected")).Selector().SelectByValue(value); }
        }

        public static string Secondary
        {
            set { WebDriver.FindAdaptedElement(By.Id("BackupMpdSelected")).Selector().SelectByValue(value); }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}