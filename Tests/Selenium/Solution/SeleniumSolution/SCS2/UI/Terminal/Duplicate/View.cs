using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Terminal.Duplicate
{
    public class View : WebObject
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
            get { return WebDriver.FindAdaptedElement(By.Id("LocationId")).Selector().SelectedOption; }
        }

        public static string InstallationMessage
        {
            set { WebDriver.FindAdaptedElement(By.Id("InstallMessage")).TextArea().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("InstallMessage")).TextArea().Text(); }
        }

        public static string NumberOfTerminals
        {
            set { WebDriver.FindAdaptedElement(By.Id("NumberOfTerminals")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("NumberOfTerminals")).TextField().Text(); }
        }

        public static IWebElement DulpicateButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("duplicate")); }
        }

        public static string DeliveryDate
        {
            set { WebDriver.FindAdaptedElement(By.Id("deliveryDate")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("deliveryDate")).TextField().Text(); }
        }

        public static string InstallationType
        {
            set { WebDriver.FindAdaptedElement(By.Id("InstallTypeId")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("InstallTypeId")).TextField().Text(); }
        }

        public static string InformationText
        {
            set { WebDriver.FindAdaptedElement(By.Id("InfoText")).TextArea().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("InfoText")).TextArea().Text(); }
        }

        public static bool MessageForAcquirers
        {
            set { WebDriver.FindAdaptedElement(By.Id("SendNotification")).CheckBox().Set(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("SendNotification")).CheckBox().IsChecked(); }
        }

        public static IWebElement Next
        {
            get { return WebDriver.FindAdaptedElement(By.Id("next")); }
        }
    }
}