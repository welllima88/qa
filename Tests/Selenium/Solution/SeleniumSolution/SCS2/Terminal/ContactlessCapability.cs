using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal
{
    public class ContactlessCapability : WebObject
    {
        public static string Status
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_terminalAttribute_ddTerminalStatus")).Selector().
                    SelectByText(value);
            }
        }

        public static void Save()
        {
            WebDriver.FindAdaptedElement(By.Id("#save")).Click();
        }
    }
}