using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Massmuation
{
    public class AcquirerChange : WebObject

    {
        public string Title
        {
            get { return WebDriver.FindElement(By.CssSelector("td#content>h1")).Text; }
        }

        public string Description
        {
            get { return WebDriver.FindElement(By.CssSelector("td#content div>p")).Text; }
        }

        public IWebElementAdapter FileChooser
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content input[name='filehandle']")); }
        }

        public IWebElementAdapter FileUploadButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#upload")); }
        }

        public string DownloadTemplate
        {
            get { return WebDriver.FindElement(By.CssSelector("td#content a[href$='/MassAcqExchange/StreamFile']")).Text; }
        }
    }
}