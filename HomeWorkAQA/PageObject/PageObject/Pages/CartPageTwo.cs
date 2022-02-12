using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObject
{
    class CartPageTwo:BasePage
    {
        private static string END_POINT = "checkout-step-two.html";

        private static readonly By FinishButtonBy = By.Id("finish");

        public CartPageTwo(IWebDriver driver,bool OpenPageByURL):base (driver,OpenPageByURL)
        {
        }
        public CartPageTwo(IWebDriver driver) : base(driver, false)
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
                return FinishBuuton.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IWebElement FinishBuuton => _driver.FindElement(FinishButtonBy);

    }
}
