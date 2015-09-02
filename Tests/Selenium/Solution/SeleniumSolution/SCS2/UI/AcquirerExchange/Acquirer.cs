using System.Collections.Generic;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = OpenQA.Selenium.IWebElement;

namespace Six.Scs.Test.UI.AcquirerExchange
{
    public class Acquirer : WebObject
    {
        private readonly IWebElement _acquirerElement;

        public Acquirer(string acquirerName)
        {
            _acquirerElement =
                WebDriver.FindElement(By.CssSelector(string.Format("td#content form table#{0}", acquirerName)));
        }

        private IEnumerable<IWebElement> BrandElements()
        {
            return _acquirerElement.FindElements(By.CssSelector("tbody>tr[id]"));
        }

        public IEnumerable<Brand> Brands()
        {
            var brands = new List<Brand>();
            foreach (var brandElement in BrandElements())
            {
                var brand = new Brand();
                brand.Id = brandElement.GetAttribute("id");
                brand.Selected = new WebElement(brandElement.FindElement(By.CssSelector("td:nth-child(1) input"))).CheckBox();
                brand.Name = new WebElement(brandElement.FindElement(By.CssSelector("td:nth-child(1)")));
                brand.NewBrand = new WebElement(brandElement.FindElement(By.CssSelector("td:nth-child(2) > select"))).Selector();
                brand.DccProvider =
                    new WebElement(brandElement.FindElement(By.CssSelector("td:nth-child(3) > select"))).Selector();
                brand.Mcc = new WebElement(brandElement.FindElement(By.CssSelector("td:nth-child(4) > select"))).Selector();
                brand.ContractNumber =
                    new WebElement(brandElement.FindElement(By.CssSelector("td:nth-child(5) > input"))).TextField();
                brands.Add(brand);
            }
            return brands;
        }
    }
}