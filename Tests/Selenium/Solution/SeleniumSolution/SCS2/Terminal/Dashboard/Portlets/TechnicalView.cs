using System;
using OpenQA.Selenium;
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
    }
}