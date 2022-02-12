using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObject
{
    class ProductPage:BasePage
    {
        private static string END_POINT = "0";

        private static string ButtonId = "sauce-labs-bike-light";
        private static readonly By AddtoCartButton = By.Id(BaseProductTest.Id+ButtonId);
        private static readonly By PriceBy = By.CssSelector(".inventory_details_price");

        public ProductPage(IWebDriver driver, bool OpenPageByUrl) : base(driver, OpenPageByUrl)
        {
        }

        public ProductPage(IWebDriver driver) : base(driver, false)
        {
        }

        public override bool IsPageOpened()          
        {
            try
            {
                return Add.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected override void OpenPage()
        {
            _driver.Navigate().GoToUrl(BaseProductTest.BaseProductURL + END_POINT);
        }

        public IWebElement Add => _driver.FindElement(AddtoCartButton);
        public IWebElement Price => _driver.FindElement(PriceBy);
    }
}
