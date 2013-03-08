using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class TerminalDashboard : WebObject
    {
        public Brands Brands;
        public CommonTerminalInfo CommonTerminalInfo;
        public Contacts Contacts;
        public TechnicalView TechnicalView;
        public TerminalSaleContract TerminalSaleContract;
        public TerminalTexts TerminalTexts;
        public TroubleTickets TroubleTickets;

        public TerminalDashboard(IWebDriverAdapter driver) : base(driver)
        {
            CommonTerminalInfo = new CommonTerminalInfo(Driver);
            Contacts = new Contacts(Driver);
            TechnicalView = new TechnicalView(Driver);
            TerminalSaleContract = new TerminalSaleContract(Driver);
            TerminalTexts = new TerminalTexts(Driver);
            TroubleTickets = new TroubleTickets(Driver);
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(By.CssSelector("input[value='Bearbeiten']")); }
        }
    }
}