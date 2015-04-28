using System.Linq;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Common.Menu
{
    public class MassMutationMenu : WebObject
    {
        public static IWebElementAdapter CustomerCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/merchant/customermassmutation/']"));
            }
        }

        public static IWebElementAdapter LocationCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/merchant/locationmassmutation/']"));
            }
        }

        public static IWebElementAdapter TerminalCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/terminal/terminalmassmutation/']"));
            }
        }

        public static IWebElementAdapter ContractCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/terminal/contractmassmutation/']"));
            }
        }

        public static IWebElementAdapter AcquirerChange
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href$='/terminal/acquirerexchangemassmutation/']")); }
        }

        public static IWebElementAdapter MassMutation
        {
            get
            {
                return
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("td#leftHandMenu span#ctl00_trvNavigation a.level2 tr td"))
                        .FirstOrDefault(e => e.Text.Contains("Massenmutation"));
            }
        }
    }
}