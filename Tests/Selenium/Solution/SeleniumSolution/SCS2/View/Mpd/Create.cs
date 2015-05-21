﻿using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Mpd
{
    public class Create : WebObject
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

        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#save")).Button(); }
        }
    }
}