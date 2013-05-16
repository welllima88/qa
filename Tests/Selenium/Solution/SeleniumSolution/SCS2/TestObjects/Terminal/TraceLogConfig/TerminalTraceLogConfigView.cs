using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.TraceLogConfig
{
    public class TerminalTraceLogConfigView : WebObject
    {
        public TerminalTraceLogConfigView(IWebDriverAdapter driver)
            : base(driver)
        {
        }

        public string ActivatedUntil
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#activateTill")).Text; }
        }

        public string Parameter
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_Parameter")).Text; }
        }

        public string Medium
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationDevice")).Text; }
        }

        public string DestinationAddress
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressIp")).Text; }
        }

        public string DestinationPort
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressPort")).Text; }
        }

        public string TelephoneIsdn
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberIsdn")).Text; }
        }

        public string TelephonePstn
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberPstn")).Text; }
        }

        public string DestinationUrl
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressUrl")).Text; }
        }

        public string DestinationUrlPort
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressPort")).Text; }
        }

        public IWebElementAdapter Edit
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("button[name='deactivate']")); }
        }
    }
}