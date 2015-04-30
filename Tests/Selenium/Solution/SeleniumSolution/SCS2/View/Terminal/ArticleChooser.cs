using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Terminal
{
    public class ArticleChooser : WebObject
    {
        public static string Filter
        {
            set { WebDriver.FindAdaptedElement(By.Id("articleFilter")).TextField().TypeText(value); }
        }

        public static IEnumerable<string> FilteredArtikelList
        {
            get
            {
                var articleElements = WebDriver.FindAdaptedElements(
                    By.CssSelector("tbody#allArticles tr td strong"))
                    .Where(e => e.Displayed);
                return WebDriver.WebElementsAsStringList(articleElements);
            }
        }

        public static IEnumerable<string> SuggestedArtikelList
        {
            get
            {
                var articleElements =
                    WebDriver.FindAdaptedElements(By.CssSelector("tbody#suggestedArticles tr td strong"));
                return WebDriver.WebElementsAsStringList(articleElements);
            }
        }

        public static string Select
        {
            set { WebDriver.FindAdaptedElement(By.LinkText(value)).Button().Click(); }
        }
    }
}