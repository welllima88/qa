using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets
{
    public class TechnicalView : PortletViewBase
    {
        //baseUrl + "TerminalTechnicalViewpointPortlet?TerminalId=21011402" + "&DontCacheRequest=cbc996ae-865f-b7cd-358a-2c0e769f53dc"

        public const string EcrLocator = "li#PosInterface";

        public TechnicalView()
        {
            PortletId = "div#frame_TerminalTechnicalViewpointPortlet ";
        }

        public static string TerminalId
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(Prefix + PortletId + "div#TerminalIdProperty div.treeGridValueCol" + Suffix))
                        .Text;
            }
        }

        public IWebElementAdapter SerialNo
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            Prefix + PortletId + "div#SerienNoProperty div.treeGridValueCol" + Suffix));
            }
        }

        public IWebElementAdapter Password
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(4)" + Suffix));
            }
        }

        public IWebElementAdapter TerminalType
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(5)" + Suffix));
            }
        }

        public IWebElementAdapter NetType
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(6)" + Suffix));
            }
        }

        public static IWebElementAdapter MpdAssign
        {
            get
            {
                OpenTree(EcrLocator);
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "div#portlet_TerminalTechnicalViewpointPortlet_content div#TechDataTree div#PrimaryMpdProperty div"));
            }
        }

        public static string PrimaryMpd
        {
            get { return WebDriver.FindAdaptedElement(By.Id("PrimaryMpdProperty")).Text; }
        }

        public static string SecondaryMpd
        {
            get { return WebDriver.FindAdaptedElement(By.Id("BackupMpdProperty")).Text; }
        }
    }
}