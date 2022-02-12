using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObject
{
     public class AllItemsPage:BasePage
    {       
        private static string END_POINT = "inventory.html";

        private static readonly By AddToCartBy = By.Id("add-to-cart-sauce-labs-backpack");
        private static readonly By DropDownBy = By.CssSelector(".select_container"); //УБРАТЬ ЕСЛИ НЕ НАДО
        private static readonly By RemoveButtonBy = By.Id("remove-sauce-labs-backpack");
     
        public AllItemsPage(IWebDriver driver, bool OpenPageByUrl) : base(driver, OpenPageByUrl)
        {
        }  

        public AllItemsPage(IWebDriver driver) : base(driver,false)
        {                  
        }

        protected override void OpenPage()
        {
            _driver.Navigate().GoToUrl(BaseTest.BaseURL + END_POINT);
        }

        public override bool IsPageOpened() // Запихнуть сюда Wait ,который будет ждать пока кнопка логина будет видна
        {
            try
            {
                return AddToCart.Displayed;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public IWebElement AddToCart => _driver.FindElement(AddToCartBy);
        public IWebElement DropDown => _driver.FindElement(DropDownBy);
        public IWebElement RemoveButton => _driver.FindElement(RemoveButtonBy);
        

    }
}
