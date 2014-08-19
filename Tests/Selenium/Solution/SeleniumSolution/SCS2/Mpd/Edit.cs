﻿using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Mpd
{
    public class Edit : WebObject
    {
        public static string Description
        {
            set { Create.Description = value; }
        }

        public static string Adress
        {
            set { Create.Adress = value; }
        }

        public static string Port
        {
            set { Create.Port = value; }
        }

        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#save")).Button(); }
        }
    }
}