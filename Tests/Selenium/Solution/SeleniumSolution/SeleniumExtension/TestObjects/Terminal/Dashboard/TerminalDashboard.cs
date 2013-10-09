using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    public class TerminalDashboard : WebObject
    {
        public BrandPortlet BrandsPortlet;
        public ContactsPortlet ContactsPortlet;
        public FixInfo FixInfo;
        public SalesContractPortlet SalesContractPortlet;
        public TechnicalViewPortlet TechnicalViewPortlet;
        public TerminalTextsPortlet TerminalTextsPortlet;
        public TroubleTicketsPortlet TroubleTicketsPortlet;

        public TerminalDashboard()
        {
            FixInfo = new FixInfo();
            BrandsPortlet = new BrandPortlet();
            ContactsPortlet = new ContactsPortlet();
            TechnicalViewPortlet = new TechnicalViewPortlet();
            SalesContractPortlet = new SalesContractPortlet();
            TerminalTextsPortlet = new TerminalTextsPortlet();
            TroubleTicketsPortlet = new TroubleTicketsPortlet();
        }

        public IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value='Bearbeiten']")); }
        }
    }
}