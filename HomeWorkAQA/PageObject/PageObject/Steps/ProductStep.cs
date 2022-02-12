using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObject
{
    class ProductStep
    {
        private IWebDriver _driver;

        public ProductStep(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ProductAdd()
        {
            ProductPage productPage = new ProductPage(_driver, true);
            productPage.Add.Click();
            return productPage.Price;
        } 
        
    }
}
