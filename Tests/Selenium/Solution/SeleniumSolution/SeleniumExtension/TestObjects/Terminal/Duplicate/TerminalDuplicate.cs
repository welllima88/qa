using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Duplicate
{
    public class TerminalDuplicate : WebObject
    {
        public static bool CopyPassword
        {
            set { WebDriver.FindAdaptedElement(By.Id("KeepPassword")).CheckBox().Set(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("KeepPassword")).CheckBox().IsChecked(); }
        }

        public static bool AcquirerNotification
        {
            set { WebDriver.FindAdaptedElement(By.Id("SendNotification")).CheckBox().Set(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("SendNotification")).CheckBox().IsChecked(); }
        }

        public static string Location
        {
            set { WebDriver.FindAdaptedElement(By.Id("LocationId")).Selector().SelectByText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("LocationId")).Selector().SelectedOption.Text; }
        }

        public static string InstallationMessage
        {
            set { WebDriver.FindAdaptedElement(By.Id("InstallMessage")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("InstallMessage")).GetAttribute("value"); }
        }

        public static string NumberOfTerminals
        {
            set { WebDriver.FindAdaptedElement(By.Id("NumberOfTerminals")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("NumberOfTerminals")).GetAttribute("value"); }
        }

        public static IWebElement DulpicateButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("duplicate")); }
        }
    }
}