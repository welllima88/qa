using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal
{
    public class ArticleChooser : WebObject
    {
        public static string Filter
        {
            set { WebDriver.FindAdaptedElement(By.Id("articleFilter")).TextField().TypeText(value); }
        }

        public static List<string> FilteredArtikelList
        {
            get
            {
                ReadOnlyCollection<IWebElementAdapter> articleElements =
                    WebDriver.FindAdaptedElements(By.CssSelector("tbody#allArticles tr td:not([style*='display: none'])"));
                return WebDriver.WebElementsAsStringList(articleElements);
            }
        }

        public static List<string> SuggestedArtikelList
        {
            get
            {
                ReadOnlyCollection<IWebElementAdapter> articleElements =
                    WebDriver.FindAdaptedElements(By.CssSelector("tbody#suggestedArticles tr td"));
                return WebDriver.WebElementsAsStringList(articleElements);
            }
        }

        public static string Select
        {
            set { WebDriver.FindAdaptedElement(By.LinkText(value)).Button().Click(); }
        }
    }
}