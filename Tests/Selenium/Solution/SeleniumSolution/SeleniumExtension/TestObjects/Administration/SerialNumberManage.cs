﻿using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Administration
{
    public class SerialNumberManage : WebObject
    {
        public static string Supplier
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("#ManufacturerId")).Selector().SelectedOption.Text;
            }
            set { WebDriver.FindAdaptedElement(By.CssSelector("#ManufacturerId")).Selector().SelectByText(value); }
        }

        public static string StartField
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#StartIndex")).TextBox().Text(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#StartIndex")).TextBox().TypeText(value); }
        }

        public static string LengthField
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#Len")).TextBox().Text(); }
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#Len")).TextBox().TypeText(value); }
        }

        public static string SerialNumbersField
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("textarea#SerialNumbersValues")).TextArea().Text();
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("textarea#SerialNumbersValues")).TextArea().TypeText(value);
            }
        }

        public static IWebElement ImportButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#import")); }
        }

        public static string Preview
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#Preview")).Text; }
        }
    }
}