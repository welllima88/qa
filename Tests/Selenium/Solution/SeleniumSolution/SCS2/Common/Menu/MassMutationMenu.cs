using System.Linq;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class MassMutationMenu : WebObject
    {
        public static IWebElementAdapter CustomerCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/MassMutation/CustomersFileUpload.aspx']")); }
        }

        public static IWebElementAdapter LocationCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/MassMutation/LocationsFileUpload.aspx']")); }
        }

        public static IWebElementAdapter TerminalCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/MassMutation/TerminalsFileUpload.aspx']")); }
        }

        public static IWebElementAdapter ContractCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/MassMutation/ContractsFileUpload.aspx']")); }
        }

        public static IWebElementAdapter AcquirerChange
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/MassAcqExchange']")); }
        }

        public static IWebElementAdapter MassMutation
        {
            // css=td#leftHandMenu a+div>a[href*='/MassMutation/']
            get
            {
                return WebDriver.FindAdaptedElement(By.XPath("//td[@id='leftHandMenu']//td[text()=' Massenmutation']"));
            }
        }
    }
}