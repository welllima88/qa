using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Massmuation
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

        public static string Todo
        {
            get { return WebDriver.FindElement(By.Id("BatchTodo")).GetAttribute("aria-valuenow"); }
        }

        public static ButtonElement RefreshButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("refresh")).Button(); }
        }

        public static IEnumerable<string> TerminalList
        {
            get
            {
                return
                    WebDriver.FindAdaptedElements(
                        By.CssSelector("div#TerminalList div p a[href*='/TerminalDashboard?TerminalId=']"))
                        .Select(e => e.Text);
            }
        }

        public static string BatchId
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "#content > div:nth-child(4) > div > div > div.panel-body > div.row > div:nth-child(1) > div > p"))
                        .Text;
            }
        }

        public static string JobId
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(
                            "#content > div:nth-child(4) > div > div > div.panel-body > div.row > div:nth-child(3) > div > p"))
                        .Text;
            }
        }

        public static bool HasFinished()
        {
            return Todo.Equals("0");
        }
    }
}