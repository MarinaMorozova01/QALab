using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObject
{
    class CartPage:BasePage
    {
        private static string END_POINT = "cart.html";

        private static readonly By CheckOutButtonBy = By.CssSelector("#checkout");

        public CartPage(IWebDriver driver, bool OpenPageByUrl) : base(driver, OpenPageByUrl)
        {          
        }

        public CartPage(IWebDriver driver) : base(driver, false)
        {
        }

        protected override void OpenPage()
        {
            _driver.Navigate().GoToUrl(BaseTest.BaseURL + END_POINT);            
        }

        public override bool IsPageOpened()
        {
            try
            {                
                return CheckoutButton.Displayed;                               
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IWebElement CheckoutButton => _driver.FindElement(CheckOutButtonBy);
    }
}
