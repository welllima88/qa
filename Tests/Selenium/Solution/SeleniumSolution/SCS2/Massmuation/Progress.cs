using System.Collections.Generic;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Massmuation
{
    public class Progress : WebObject
    {
        public static string Failed
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Massmutation_Failed")).Text; }
        }

        public static string Type
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Massmutation_BatchType")).Text; }
        }

        public static string Done
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Massmutation_Done")).Text; }
        }

        public static string Total
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Massmutation_All")).Text; }
        }

        public static List<string> TerminalList
        {
            get
            {
                return
                    WebDriver.WebElementsAsStringList(
                        WebDriver.FindAdaptedElements(
                            By.CssSelector("table#TerminalList tbody tr td a[href*='/TerminalDashboard?TerminalId=']")));
            }
        }

        public static bool HasFinished()
        {
            return string.Equals(Total, Done);
        }
    }
}