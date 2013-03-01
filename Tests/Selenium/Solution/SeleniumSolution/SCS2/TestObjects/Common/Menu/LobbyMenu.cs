using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    /// <summary>
    /// css Locator have problems with menu so use xpath until resolved the reason...
    /// </summary>
    public class LobbyMenu
    {
        public const string MenuPrefix = "//td[@id='leftHandMenu']/span[@id=\"ctl00_trvNavigation\"]/descendant::";
        private readonly IWebDriverAdapter _driver;
        public CustomerMenu Customer;
        public LocationMenu LocationMenu;
        public MassMutationMenu MassMutation;
        public TerminalMenu TerminalMenu;
        public TicketMenu Ticket;

        public LobbyMenu(IWebDriverAdapter driver)
        {
            _driver = driver;
            MassMutation = new MassMutationMenu(_driver);
            Customer = new CustomerMenu(_driver);
            Customer = new CustomerMenu(_driver);
            LocationMenu = new LocationMenu(_driver);
            TerminalMenu = new TerminalMenu(_driver);
            Ticket = new TicketMenu(_driver);
        }

        public IWebElement Lobby
        {
            get { return _driver.FindElement(By.CssSelector("a[href*='Default.aspx']")); }
        }
    }
}