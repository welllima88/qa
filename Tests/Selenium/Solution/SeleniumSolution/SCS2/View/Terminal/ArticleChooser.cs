using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.View.Terminal
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
                IEnumerable<IWebElementAdapter> articleElements = WebDriver.FindAdaptedElements(
                    By.CssSelector("tbody#allArticles tr td strong"))
                    .Where(e => e.Displayed);
                return WebDriver.WebElementsAsStringList(articleElements);
            }
        }

        public static List<string> SuggestedArtikelList
        {
            get
            {
                ReadOnlyCollection<IWebElementAdapter> articleElements =
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