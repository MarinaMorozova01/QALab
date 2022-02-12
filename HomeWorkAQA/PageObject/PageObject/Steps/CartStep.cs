using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObject
{
    class CartStep
    {
        private IWebDriver _driver;

        public CartStep(IWebDriver driver)
        {
            _driver = driver;
        }

        public void CartCheckout()
        {
            CartPage cartPage = new CartPage(_driver, true);
            cartPage.CheckoutButton.Click();
        }
    }
}
