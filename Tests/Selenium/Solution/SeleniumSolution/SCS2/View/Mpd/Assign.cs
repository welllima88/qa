using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Mpd
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