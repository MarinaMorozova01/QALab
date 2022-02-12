using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObject
{
    class CartOneStep
    {
        private IWebDriver _driver;

        public CartOneStep(IWebDriver driver)
        {
            _driver = driver;
        }

        public void FieldsFilling()
        {
            CartPageOne cartPage = new CartPageOne(_driver, true);
            cartPage.FirstName.SendKeys("Marina");
            cartPage.LastName.SendKeys("Morozova");
            cartPage.Zip.SendKeys("211317");
            cartPage.ContinueButton.Click();
        }
    }
}
