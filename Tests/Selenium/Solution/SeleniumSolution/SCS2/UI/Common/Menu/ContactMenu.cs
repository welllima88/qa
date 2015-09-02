using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.UI.Common.Menu
{
    public class ContactMenu : WebObject
    {
        public static ButtonElement Contact
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/Person/?PERSONID=']")).Button();
            }
        }

        public static ButtonElement ContactEdit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='Person/Edit?PERSONID=']")).Button();
            }
        }
    }
}