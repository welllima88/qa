using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.TraceLogConfig
{
    public class TerminalTraceLogConfigEdit : WebObject
    {
        public static string ActivatedUntil
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#activateTill")).TextField().TypeText(value); }
        }

        public static string Parameter
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_Parameter")).TextField().TypeText(value); }
        }

        public static string Medium
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationDevice"))
                    .Selector()
                    .SelectByValue(value);
            }
        }

        public static string DestinationAddress
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressIp"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string DestinationPort
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_DestinationAddressPort"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string TelephoneIsdn
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberIsdn")).TextField().TypeText(value);
            }
        }

        public static string TelephonePstn
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_PhoneNumberPstn")).TextField().TypeText(value);
            }
        }

        public static string DestinationUrl
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressUrl")).TextField().TypeText(value);
            }
        }

        public static string DestinationUrlPort
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#ConfigData_InternetAddressPort")).TextField().TypeText(value);
            }
        }

        public static IWebElementAdapter Save
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#activate")); }
        }

        public static IWebElementAdapter Deactivate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='deactivate']")); }
        }
    }
}