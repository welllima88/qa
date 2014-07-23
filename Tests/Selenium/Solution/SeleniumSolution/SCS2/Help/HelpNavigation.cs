﻿using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Help
{
    public class HelpNavigation : WebObject
    {
        public static IWebElementAdapter ReleaseNotes
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("body div.navbar ul.nav li a[href$='/help/Releasenotes']"));
            }
        }

        public static IWebElementAdapter Scs2
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("body div.navbar ul.nav li a[href$='/help/SCS2']"));
            }
        }

        public static IWebElementAdapter ScsHelp
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("body div.navbar ul.nav li a[href$='/help/SCS2']"));
            }
        }
    }
}