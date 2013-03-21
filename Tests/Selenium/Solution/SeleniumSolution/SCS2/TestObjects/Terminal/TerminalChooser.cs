using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
{
    public class TerminalChooser : WebObject
    {
        public TerminalChooser(IWebDriverAdapter driver) : base(driver)
        {
        }

        //ctl00_bodyContentPlaceHolder_articleSelector_trvArticleTree
        public String TerminalType
        {
            set { TreeClick(1, value); }
        }

        public String TerminalSubType
        {
            set { TreeClick(2, value); }
        }

        public String NetType
        {
            set { TreeClick(3, value); }
        }

        public String Article
        {
            //behaves like confirm button, when clicked the link
            set { TreeClick(4, value); }
        }

        public String ArticleLookup
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_articleSelector_inpNumber"))
                    .
                    TypeText(value);
                Driver.FindElement(By.CssSelector("input#ctl00_bodyContentPlaceHolder_articleSelector_inpNumber")).
                    SendKeys //send keys here necessary!!
                    (Keys.Enter);
            }
            //use Article(" xenta AUTONOM, TCP/IP / 15463").Click to continue to next screen
        }

        /// <summary>
        /// 
        /// </summary>
        public List<String> ArtikelList
        {
            get
            {
                return
                    Driver.WebElementsAsStringList(
                        Driver.FindElements(
                            By.CssSelector("span#ctl00_bodyContentPlaceHolder_articleSelector_trvArticleTree>a")));
            }
        }

        public IWebElement ArticleSelector
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_articleSelector_Image1"));
            }
        }

        private void TreeClick(int level, string value)
        {
            //TODO: find a way to use CSS-Selector instead of xpath (problem with clicking, when css-locator used)
            /* this doesnt work:
           Driver.FindElement(By.XPath("//td[contains(text(),'" + value + "')]")).Click();
           Driver.FindElement(By.XPath("//a[@class=level1/td[text()=\" xentissimo\"]")).Click();
           Driver.FindElement(By.CssSelector("a.level1 td[textContent~=\"" + value + "\"]")).Click();
           Driver.FindElement(By.CssSelector("a.level1[textContent~='xentissimo']")).Click();
           Driver.FindElement(By.CssSelector("a.level1 td[textContent~=\"" + value + "\"]")).Click();
           Driver.FindElement(By.CssSelector("td[textContent=' " + value + "'].data")).Click();
           Driver.FindElement(By.CssSelector("a.level" + level + " td[textContent~='" + value + "'].data")).Click();
            */
            // Todo: make use of level, to be sure choosing in the right tree node
            Driver.FindElement(By.XPath("//td[contains(text(),'" + value + "')]")).Click();
        }
    }
}