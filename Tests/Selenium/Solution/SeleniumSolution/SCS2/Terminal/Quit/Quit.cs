using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Quit
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
            set { WebDriver.FindAdaptedElement(By.Id("Motivation")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("Motivation")).TextField().Text(); }
        }

        public static IWebElementAdapter Save
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}