using System;
using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.Dashboard
{
    public class TechnicalViewPortlet : PortletViewBase
    {
        //baseUrl + "TerminalTechnicalViewpointPortlet?TerminalId=21011402" + "&DontCacheRequest=cbc996ae-865f-b7cd-358a-2c0e769f53dc"

        public TechnicalViewPortlet()
        {
            PortletId = "div#frame_TerminalTechnicalViewpointPortlet ";
        }

        public string TerminalId
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(1)" + Suffix)).Text;
            }
        }

        public IWebElement SerialNo
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(3)" + Suffix));
            }
        }

        public IWebElement Password
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(4)" + Suffix));
            }
        }

        public IWebElement TerminalType
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(5)" + Suffix));
            }
        }

        public IWebElement NetType
        {
            get
            {
                return
                    WebDriver.FindElement(
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