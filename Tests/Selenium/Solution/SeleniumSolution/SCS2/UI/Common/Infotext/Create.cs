using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.UI.Common.Infotext
{
    public class Create : WebObject
    {
        public static string Text
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("textarea#InfoText_Text")).TextArea().TypeText(value); }
        }

        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")).Button(); }
        }

        public static ButtonElement CancelButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("cancel")).Button(); }
        }
    }
}