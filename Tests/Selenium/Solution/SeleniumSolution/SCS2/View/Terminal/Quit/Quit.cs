using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Terminal.Quit
{
    public class Quit : WebObject
    {
        public static string State
        {
            set { WebDriver.FindAdaptedElement(By.Id("StateAndSubState")).Selector().SelectByText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("StateAndSubState")).Selector().SelectedOption; }
        }

        public static bool InstallationOnSiteRequested
        {
            set { WebDriver.FindAdaptedElement(By.Id("InstallationOnSiteRequested")).CheckBox().Set(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("InstallationOnSiteRequested")).CheckBox().IsChecked(); }
        }

        public static string Reason
        {
            set { WebDriver.FindAdaptedElement(By.Id("TerminalState_Reason")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("TerminalState_Reason")).TextField().Text(); }
        }

        public static void Save()
        {
            WebDriver.FindAdaptedElement(By.Id("save")).Click();
        }
    }
}