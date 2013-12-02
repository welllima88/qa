using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal
{
    public class TerminalChooser : WebObject
    {
        public static string ArticleFilter
        {
            set { WebDriver.FindAdaptedElement(By.Id("articleFilter")).TextBox().TypeText(value); }
        }

        public static List<string> FilteredArtikelList
        {
            get
            {
                ReadOnlyCollection<IWebElement> articleElements =
                    WebDriver.FindElements(By.CssSelector("tbody#allArticles tr td:not([style*='display: none'])"));
                return WebDriver.WebElementsAsStringList(articleElements);
            }
        }

        public static List<string> SuggestedArtikelList
        {
            get
            {
                ReadOnlyCollection<IWebElement> articleElements =
                    WebDriver.FindElements(By.CssSelector("tbody#suggestedArticles tr td"));
                return WebDriver.WebElementsAsStringList(articleElements);
            }
        }

        public static string Article
        {
            set { WebDriver.FindAdaptedElement(By.LinkText(value)).Click(); }
        }
    }
}