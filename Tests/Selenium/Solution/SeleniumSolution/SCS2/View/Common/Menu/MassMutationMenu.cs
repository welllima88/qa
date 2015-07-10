using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Common.Menu
{
    public class MassMutationMenu : WebObject
    {
        public static IWebElement CustomerCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/merchant/customermassmutation/']"));
            }
        }

        public static IWebElement LocationCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/merchant/locationmassmutation/']"));
            }
        }

        public static IWebElement TerminalCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/terminal/terminalmassmutation/']"));
            }
        }

        public static IWebElement ContractCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/terminal/contractmassmutation/']"));
            }
        }

        public static IWebElement AcquirerChange
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/terminal/acquirerexchangemassmutation/']"));
            }
        }

        public static IWebElement MassMutation
        {
            get
            {
                return
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("td#leftHandMenu span#ctl00_trvNavigation a.level2 tr td"))
                        .FirstOrDefault(e => e.Text.Contains("Massenmutation"));
            }
        }

        public static IWebElement BusinessTemplate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href$='/BusinessTemplate/Change']"));
            }
        }
    }
}