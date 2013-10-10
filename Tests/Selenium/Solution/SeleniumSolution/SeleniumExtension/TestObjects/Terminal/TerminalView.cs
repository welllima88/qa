using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal
{
    public class TerminalView : WebObject
    {
        public static Article Article;
        public static Base Base;
        public static Parameter Parameter;
        public Brands Brands;

        public TerminalView()
        {
            Article = new Article();
            Base = new Base();
            Brands = new Brands();
            Parameter = new Parameter();
        }

        public IWebElement EditButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value='Bearbeiten']")); }
        }
    }
}