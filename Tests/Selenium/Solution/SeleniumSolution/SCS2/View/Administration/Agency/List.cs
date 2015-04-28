﻿using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Administration.Agency
{
    public class List : WebObject
    {
        public static IWebElementAdapter Create
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='create']")); }
        }
    }
}