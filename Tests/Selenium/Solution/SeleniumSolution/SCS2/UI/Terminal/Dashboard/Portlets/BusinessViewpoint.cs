using OpenQA.Selenium;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Terminal.Dashboard.Portlets
{
    public class BusinessViewpoint : PortletBase
    {
        public static IWebElement ReceiptHeader
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#frame_TerminalBusinessViewpointPortlet div#BVP_ReceiptHeader"));
            }
        }

        public static string Status
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("div#frame_TerminalBusinessViewpointPortlet #BVP_State")).Text;
            }
        }

        public static string TerminalType
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_TerminalBusinessViewpointPortlet #BVP_Appearance")).Text;
            }
        }

        public static string Color
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_TerminalBusinessViewpointPortlet div#BVP_TerminalColor div.treeGridValueCol span"))
                        .Text;
            }
        }

        public static string TerminalLanguage
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_TerminalBusinessViewpointPortlet div#BVP_TerminalAppearance_LanguageProperty div.treeGridValueCol span"))
                        .Text;
            }
        }

        public static IWebElement ArticleChange
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_TerminalBusinessViewpointPortlet span#BVP_Appearance a[href*='/TerminalArticleSelector/TerminalArticleChange/?TerminalId=']"))
                    ;
            }
        }

        public static IWebElement MoveTerminal
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#frame_TerminalBusinessViewpointPortlet div.portletLinks a[href*='/TerminalChangeLocation?TerminalId=']"));
            }
        }
    }
}