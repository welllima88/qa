using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
{
    public class TerminalView : WebObject
    {
        public Article Article;
        public Base Base;
        public Brands Brands;
        public Parameter Parameter;

        public TerminalView(IWebDriverAdapter driver) : base(driver)
        {
            Article = new Article(Driver);
            Base = new Base(Driver);
            Brands = new Brands(Driver);
            Parameter = new Parameter(Driver);
        }

        public IWebElement EditButton
        {
            get { return Driver.FindElement(By.CssSelector("input[value='Bearbeiten']")); }
        }
    }
}