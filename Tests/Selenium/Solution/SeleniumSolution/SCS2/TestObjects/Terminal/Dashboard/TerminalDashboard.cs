using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class TerminalDashboard : WebObject
    {
        public BrandsPortlet BrandsPortlet;
        public FixInfo FixInfo;
        public ContactsPortlet ContactsPortlet;
        public SalesContractPortlet SalesContractPortlet;
        public TechnicalViewPortlet TechnicalViewPortlet;
        public TerminalTextsPortlet TerminalTextsPortlet;
        public TroubleTicketsPortlet TroubleTicketsPortlet;

        public TerminalDashboard(IWebDriverAdapter driver) : base(driver)
        {
            FixInfo = new FixInfo(Driver);
            ContactsPortlet = new ContactsPortlet(Driver);
            TechnicalViewPortlet = new TechnicalViewPortlet(Driver);
            SalesContractPortlet = new SalesContractPortlet(Driver);
            TerminalTextsPortlet = new TerminalTextsPortlet(Driver);
            TroubleTicketsPortlet = new TroubleTicketsPortlet(Driver);
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(By.CssSelector("input[value='Bearbeiten']")); }
        }
    }
}