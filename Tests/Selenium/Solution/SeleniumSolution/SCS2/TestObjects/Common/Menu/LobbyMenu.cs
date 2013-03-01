using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    /// <summary>
    /// css Locator have problems with menu so use xpath until resolved the reason...
    /// </summary>
    public class LobbyMenu : WebObject
    {
        public const string MenuPrefix = "//td[@id='leftHandMenu']/span[@id=\"ctl00_trvNavigation\"]/descendant::";
        public CustomerMenu Customer;
        public LocationMenu LocationMenu;
        public MassMutationMenu MassMutation;
        public TerminalMenu TerminalMenu;
        public TicketMenu Ticket;

        public LobbyMenu(IWebDriverAdapter driver) : base(driver)
        {
            MassMutation = new MassMutationMenu(Driver);
            Customer = new CustomerMenu(Driver);
            Customer = new CustomerMenu(Driver);
            LocationMenu = new LocationMenu(Driver);
            TerminalMenu = new TerminalMenu(Driver);
            Ticket = new TicketMenu(Driver);
        }

        public IWebElement Lobby
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='Default.aspx']")); }
        }
    }
}