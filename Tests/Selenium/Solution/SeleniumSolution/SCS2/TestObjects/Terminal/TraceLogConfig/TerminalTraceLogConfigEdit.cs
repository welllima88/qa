using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.TraceLogConfig
{
    public class TerminalTraceLogConfigEdit : WebObject
    {
        public TerminalTraceLogConfigEdit(IWebDriverAdapter driver)
            : base(driver)
        {
        }

        public IWebElementAdapter ActivatedUntil
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#activateTill")); }
        }

        public IWebElementAdapter Parameter
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_Parameter")); }
        }

        public SelectElement Medium
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationDevice")).Selector(); }
        }

        public IWebElementAdapter DestinationAddress
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressIp")); }
        }

        public IWebElementAdapter DestinationPort
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressPort")); }
        }

        public IWebElementAdapter TelephoneIsdn
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberIsdn")); }
        }

        public IWebElementAdapter TelephonePstn
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberPstn")); }
        }

        public IWebElementAdapter DestinationUrl
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressUrl")); }
        }

        public IWebElementAdapter DestinationUrlPort
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressPort")); }
        }

        public IWebElementAdapter Save
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("button[value='speichern']")); }
        }

        public IWebElementAdapter Cancel
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("button[name='cancel']")); }
        }

        public IWebElementAdapter Deactivate
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("button[name='deactivate']")); }
        }
    }
}