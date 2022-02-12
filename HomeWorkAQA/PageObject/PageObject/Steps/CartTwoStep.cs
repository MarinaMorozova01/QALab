using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObject
{
    class CartTwoStep
    {
        private static IWebDriver _driver;

        public CartTwoStep(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Finish()
        {
            CartPageTwo cartPageTwo = new CartPageTwo(_driver, true);
            cartPageTwo.FinishBuuton.Click();
        }
    }
}
