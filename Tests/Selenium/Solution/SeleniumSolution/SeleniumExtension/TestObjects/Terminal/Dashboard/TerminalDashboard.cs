using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    public class TerminalDashboard : WebObject
    {
        public static BrandPortlet BrandsPortlet;
        public static ContactsPortlet ContactsPortlet;
        public static TerminFixInfo TerminFixInfo;
        public static SalesContractPortlet SalesContractPortlet;
        public static TechnicalViewPortlet TechnicalViewPortlet;
        public static TerminalTextsPortlet TerminalTextsPortlet;
        public static TroubleTicketsPortlet TroubleTicketsPortlet;

        public static IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value='Bearbeiten']")); }
        }
    }
}