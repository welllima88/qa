using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class TerminalDashboard : WebObject
    {
        public Brands Brands;
        public FixInfo FixInfo;
        public Contacts Contacts;
        public SaleContract SaleContract;
        public TechnicalView TechnicalView;
        public TerminalTexts TerminalTexts;
        public TroubleTickets TroubleTickets;

        public TerminalDashboard(IWebDriverAdapter driver) : base(driver)
        {
            FixInfo = new FixInfo(Driver);
            Contacts = new Contacts(Driver);
            TechnicalView = new TechnicalView(Driver);
            SaleContract = new SaleContract(Driver);
            TerminalTexts = new TerminalTexts(Driver);
            TroubleTickets = new TroubleTickets(Driver);
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(By.CssSelector("input[value='Bearbeiten']")); }
        }
    }
}