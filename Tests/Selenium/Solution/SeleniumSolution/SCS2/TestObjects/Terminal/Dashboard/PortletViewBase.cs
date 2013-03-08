using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public abstract class PortletViewBase : WebObject
    {
        protected PortletViewBase(IWebDriverAdapter driver) : base(driver)
        {
            Suffix=" div.portletKeyValueRow div.treeGridValueCol";
        }

        public IWebElement Refresh
        {
            get
            {
                throw new NotImplementedException("Refresh to Portlet not implemented");
                return Driver.FindElement(By.CssSelector("input[value='Bearbeiten']"));
            }
        }

        public IWebElement Minimize
        {
            get
            {
                throw new NotImplementedException("Refresh to Portlet not implemented");
                return Driver.FindElement(By.CssSelector("input[value='Bearbeiten']"));
            }
        }
    }
}