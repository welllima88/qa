using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal
{
    public class Replace : WebObject
    {
        public static string InstallationType
        {
            set { WebDriver.FindAdaptedElement(By.Id("InstallTypeId")).Selector().SelectByText(value); }
        }

        public static string SalesContract
        {
            set { WebDriver.FindAdaptedElement(By.Id("HandoverTypeId")).Selector().SelectByText(value); }
        }

        public static string SupportContract
        {
            set { WebDriver.FindAdaptedElement(By.Id("SupportContractId")).Selector().SelectByText(value); }
        }

        public static string Contactless
        {
            set { WebDriver.FindAdaptedElement(By.Id("ContactlessInd")).Selector().SelectByText(value); }
        }

        public static string InstallationRemark
        {
            set { WebDriver.FindAdaptedElement(By.Id("InstallTypeRemark")).TextArea().TypeText(value); }
        }

        public static string Infotext
        {
            set { WebDriver.FindAdaptedElement(By.Id("InfoText")).TextArea().TypeText(value); }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }

        public static string DeliveryDate
        {
            set { WebDriver.FindAdaptedElement(By.Id("deliveryDateId")).TextField().TypeText(value); }
        }

        public static bool SendNotifiaction
        {
            set { WebDriver.FindAdaptedElement(By.Id("SendToMultipay")).CheckBox().Set(value); }
        }
    }
}