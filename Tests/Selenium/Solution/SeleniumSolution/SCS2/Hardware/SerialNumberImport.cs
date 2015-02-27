﻿using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Hardware
{
    public class SerialNumberImport : WebObject
    {
        public static string Title
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#content>h1"))
                        .Text;
            }
        }

        public static string Description
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content div>div>p")).Text; }
        }

        public static IWebElementAdapter FileChooser
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div span input[type='file']")); }
        }

        public static IWebElementAdapter FileUploadButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("upload")); }
        }

        public static string DownloadTemplate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/HWManagementImportSerialNumber/StreamFile']"))
                        .Text;
            }
        }
    }
}