using System.Linq;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.View.Common.Menu
{
    /// <summary>
    ///     css Locator have problems with menu so use xpath until resolved the reason...
    /// </summary>
    public class LobbyMenu : WebObject
    {
        public static IWebElementAdapter Lobby
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/Lobby/']")); }
        }

        public static IWebElementAdapter SimCardManage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/SIMCard']")); }
        }

        public static IWebElementAdapter SerialNumberManage
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href$='/SerialNumberManagement/']"));
            }
        }

        public static IWebElementAdapter AccessoireOrders
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href$='/AccessoriesOrder/List/']"));
            }
        }

        public static IWebElementAdapter HardwareManage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href$='/HWManagement/SingleDevice']")); }
        }

        public static IWebElementAdapter AcccessoiresOrders
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/AccessoireShop/AccessoireOrder/List/']"));
            }
        }

        public static IWebElementAdapter MyIncidents
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/TroubleTicket/Incident/Supporter']"));
            }
        }

        public static IWebElementAdapter MyTeams
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href$='/TroubleTicket/Incident/Teams']"));
            }
        }

        public static IWebElementAdapter TerminalReturnShipping
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href$='/TerminalReturnShipping/']"));
            }
        }

        public static void Expand(string menuName)
        {
            // css=td#leftHandMenu a+div>a[href*='/MassMutation/']
            IWebElement massMenu =
                WebDriver.FindElements(
                    By.CssSelector(
                        "tbody tr#rowContent td#leftHandMenu span#ctl00_trvNavigation a.level2:not(.open) td"))
                    .FirstOrDefault(e => e.Text.Contains(menuName));

            if (massMenu != null) massMenu.Click();
        }
    }
}