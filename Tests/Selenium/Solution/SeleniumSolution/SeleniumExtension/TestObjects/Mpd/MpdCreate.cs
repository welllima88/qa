﻿using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Mpd
{
    public class MpdCreate : WebObject
    {
        public static string Description
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Description")).TextField().TypeText(value); }
        }

        public static string Adress
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#InetAddr")).TextField().TypeText(value); }
        }

        public static string Port
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#InetPort")).TextField().TypeText(value); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#save")); }
        }
    }
}