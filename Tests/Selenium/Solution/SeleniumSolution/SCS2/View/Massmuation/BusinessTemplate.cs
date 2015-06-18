﻿using System.Collections.Generic;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Massmuation
{
    public class BusinessTemplate : WebObject
    {
        private static readonly char _separator = '\n';

        public static IEnumerable<string> TerminalIds
        {
            //TODO:     not reliable at the moment due to angular
            get
            {
                return WebDriver.FindAdaptedElement(By.Id("terminalIds"))
                    .TextArea().Text().Split(_separator);
            }
            set
            {
                var lines = "";
                foreach (var terminalId in value)
                {
                    lines = string.Concat(lines, string.Concat(terminalId, _separator));
                }
                WebDriver.FindAdaptedElement(By.Id("terminalIds"))
                    .TextArea()
                    .TypeText(lines);
                //wait until ajax done:
                WebDriver.WebDriverWait().Until(d => Save.Enabled);
            }
        }

        public static string Acquirer
        {
            set { WebDriver.FindAdaptedElement(By.Id("acquirerDropdown")).Selector().SelectByText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("acquirerDropdown")).Selector().SelectedOption; }
        }

        public static string ActualBusinessTemplate
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.Id("usedBusinessTemplateDropdown")).Selector().SelectedOption;
            }
            set { WebDriver.FindAdaptedElement(By.Id("usedBusinessTemplateDropdown")).Selector().SelectByText(value); }
        }

        public static string NewBusinessTemplate
        {
            get { return WebDriver.FindAdaptedElement(By.Id("newBusinessTemplateDropdown")).Selector().SelectedOption; }
            set { WebDriver.FindAdaptedElement(By.Id("newBusinessTemplateDropdown")).Selector().SelectByText(value); }
        }

        public static IWebElementAdapter Save
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }

        public static IWebElementAdapter Reload
        {
            get { return WebDriver.FindAdaptedElement(By.Id("reload")); }
        }
    }
}