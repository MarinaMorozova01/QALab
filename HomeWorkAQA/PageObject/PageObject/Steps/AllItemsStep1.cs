using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObject
{
    class AllItemsStep1
    {
        private IWebDriver _driver;

        public AllItemsStep1(IWebDriver driver)
        {
            _driver = driver;
        }

        public void AllItems()
        {
            AllItemsPage allItems = new AllItemsPage(_driver,true);
            allItems.AddToCart.Click();          
        } 
        
        public IWebElement Remove()
        {
            AllItemsPage allItems = new AllItemsPage(_driver, true);
            return allItems.RemoveButton;
        }
    }
}
