using System.Collections.Generic;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Massmuation
{
    public class Progress : WebObject
    {
        public static string Passed
        {
            get { return WebDriver.FindElement(By.Id("BatchSuccess")).GetAttribute("aria-valuenow"); }
        }

        public static string Failed
        {
            get { return WebDriver.FindElement(By.Id("BatchFailed")).GetAttribute("aria-valuenow"); }
        }

        public static string Type
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Massmutation_BatchType")).Text; }
        }

        public static string Done
        {
            get { return WebDriver.FindElement(By.Id("BatchProgress")).GetAttribute("jobs_done"); }
        }

        public static string Total
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Massmutation_All")).Text; }
        }

        public static ButtonElement RefreshButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("refresh")).Button(); }
        }

        public static List<string> TerminalList
        {
            get
            {
                return
                    WebDriver.WebElementsAsStringList(
                        WebDriver.FindAdaptedElements(
                            By.CssSelector("div#TerminalList div p a[href*='/TerminalDashboard?TerminalId=']")));
            }
        }

        public static bool HasFinished()
        {
            return string.Equals(Total, Done);
        }
    }
}