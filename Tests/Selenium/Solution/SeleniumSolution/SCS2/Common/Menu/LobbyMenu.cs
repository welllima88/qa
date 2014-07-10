using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    /// <summary>
    ///     css Locator have problems with menu so use xpath until resolved the reason...
    /// </summary>
    public class LobbyMenu : WebObject
    {        
        public static IWebElement Lobby
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.LobbyMenu_Lobby)); }
        }

        public static IWebElement SimCardManage
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.SimCardManagement)); }
        }

        public static IWebElement SerialNumberManage
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href$='/SerialNumberManagement/']")); }
        }

        public static IWebElement BillableTerminalsMenu
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href$='/BillableTerminals/']")); }
        }

        public static IWebElement PostDeliveryTickets
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href$='/DeliveryTicketsPost/']")); }
        }

        public static IWebElement AccessoireOrders
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href$='/AccessoriesOrder/List/']")); }
        }

        public static IWebElement HardwareManage
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href$='/HWManagement']")); }
        }

        public static IWebElement AcccessoiresOrders
        {
            get { return WebDriver.FindElement(By.CssSelector("a[href$='/AccessoriesOrder/List/']")); }
        }
    }
}