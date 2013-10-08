using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Massmuation
{
    public class Massmuation : WebObject

    {
        public string Title
        {
            get { return WebDriver.FindElement(By.CssSelector("span#ctl00_bodyContentPlaceHolder_lblMainTitle>h1")).Text; }
        }

        public string Description
        {
            get { return WebDriver.FindElement(By.CssSelector("td#content>span>p")).Text; }
        }

        public IWebElementAdapter FileChooser
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ctl00_bodyContentPlaceHolder_fileUpload")); }
        }

        public IWebElementAdapter FileUploadButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ctl00_bodyContentPlaceHolder_btnUpload")); }
        }

        public string DownloadTemplate
        {
            get { return WebDriver.FindElement(By.Id("ctl00_bodyContentPlaceHolder_lbDownload")).Text; }
        }
    }
}