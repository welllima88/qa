using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal
{
    public class Replace : WebObject
    {
        public static string InstallationType
        {
            set { WebDriver.FindAdaptedElement(By.Id("InstallTypeId")).Selector().SelectByText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("InstallTypeId")).Selector().SelectedOption; }
        }

        public static string SalesContract
        {
            set { WebDriver.FindAdaptedElement(By.Id("HandoverTypeId")).Selector().SelectByText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("HandoverTypeId")).Selector().SelectedOption; }
        }

        public static string SupportContract
        {
            set { WebDriver.FindAdaptedElement(By.Id("SupportContractId")).Selector().SelectByText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("SupportContractId")).Selector().SelectedOption; }
        }

        public static string Contactless
        {
            set { WebDriver.FindAdaptedElement(By.Id("ContactlessInd")).Selector().SelectByText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("ContactlessInd")).Selector().SelectedOption; }
        }

        public static string InstallationRemark
        {
            set { WebDriver.FindAdaptedElement(By.Id("InstallTypeRemark")).TextArea().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("InstallTypeRemark")).TextArea().Text(); }
        }

        public static string Infotext
        {
            set { WebDriver.FindAdaptedElement(By.Id("InfoText")).TextArea().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("InfoText")).TextArea().Text(); }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }

        public static string DeliveryDate
        {
            set { WebDriver.FindAdaptedElement(By.Id("deliveryDateId")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("deliveryDateId")).TextField().Text(); }
        }

        public static bool SendNotifiaction
        {
            set { WebDriver.FindAdaptedElement(By.Id("SendToMultipay")).CheckBox().Set(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("SendToMultipay")).CheckBox().IsChecked(); }
        }

        public static string ContractPeriodMinimum
        {
            set { WebDriver.FindAdaptedElement(By.Id("contractPeriodMinimum")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("contractPeriodMinimum")).TextField().Text(); }
        }
    }
}