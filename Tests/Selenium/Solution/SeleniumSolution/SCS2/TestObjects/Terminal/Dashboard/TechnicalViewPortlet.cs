using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class TechnicalViewPortlet : PortletViewBase
    {
        //baseUrl + "TerminalTechnicalViewpointPortlet?TerminalId=21011402" + "&DontCacheRequest=cbc996ae-865f-b7cd-358a-2c0e769f53dc"

        public TechnicalViewPortlet(IWebDriverAdapter driver) : base(driver)
        {
            PortletId = "div#frame_TerminalTechnicalViewpointPortlet ";
        }

        public IWebElement TerminalId
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(1)" + Suffix));
            }
        }

        public IWebElement SerialNo
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(3)" + Suffix));
            }
        }

        public IWebElement Password
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(4)" + Suffix));
            }
        }

        public IWebElement TerminalType
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(5)" + Suffix));
            }
        }

        public IWebElement NetType
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            Prefix + PortletId + "li:nth-child(6)" + Suffix));
            }
        }
    }
}