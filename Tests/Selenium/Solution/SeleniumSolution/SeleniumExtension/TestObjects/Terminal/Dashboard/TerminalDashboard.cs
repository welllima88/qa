using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
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