using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets
{
    public class TechnicalView : PortletViewBase
    {
        //baseUrl + "TerminalTechnicalViewpointPortlet?TerminalId=21011402" + "&DontCacheRequest=cbc996ae-865f-b7cd-358a-2c0e769f53dc"

        public TechnicalView()
        {
            PortletId = "div#frame_TerminalTechnicalViewpointPortlet ";
        }

        public string TerminalId
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(1)" + Suffix)).Text;
            }
        }

        public IWebElementAdapter SerialNo
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(3)" + Suffix));
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

        public static string Headline
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter MpdAssign
        {
            get
            {
                WebDriverWait w = WebDriver.WebDriverWait();
                w.Until(d => d.FindElement(By.CssSelector("li#PosInterface.jstree-closed>ins"))).Click();
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