using OpenQA.Selenium;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal.Dashboard.Brand;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal.Dashboard
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