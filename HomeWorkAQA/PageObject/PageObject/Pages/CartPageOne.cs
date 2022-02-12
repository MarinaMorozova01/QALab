using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObject
{
    class CartPageOne:BasePage
    {
        private static string END_POINT = "checkout-step-one.html";
        private static readonly By FirstNameBy = By.Id("first-name");
        private static readonly By SecondNameBy = By.Id("last-name");
        private static readonly By ZipBy = By.Id("postal-code");
        private static readonly By ContinueButtonBy = By.Id("continue");

        public CartPageOne(IWebDriver driver,bool OpenPageByURL): base(driver,OpenPageByURL)
        {
        }
        public CartPageOne(IWebDriver driver) : base(driver, false)
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
                return FirstName.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IWebElement FirstName => _driver.FindElement(FirstNameBy);
        public IWebElement LastName => _driver.FindElement(SecondNameBy);
        public IWebElement Zip => _driver.FindElement(ZipBy);
        public IWebElement ContinueButton => _driver.FindElement(ContinueButtonBy);
    }
}
