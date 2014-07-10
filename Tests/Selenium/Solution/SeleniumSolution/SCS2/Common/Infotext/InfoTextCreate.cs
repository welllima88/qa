using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Infotext
{
    public class InfoTextCreate : WebObject
    {
        public static string Text
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("textarea#InfoText_Text")).TextArea().TypeText(value); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#save")); }
        }

        public static IWebElement CancelButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#cancel")); }
        }
    }
}