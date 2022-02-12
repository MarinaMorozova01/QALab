using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace PageObject
{
    class LoginStep
    {
        private IWebDriver _driver;
        public LoginStep(IWebDriver Driver)
        {
            _driver = Driver;
        }
        
        public void LogIn()
        {
            LoginPage loginPage = new LoginPage(_driver,true); 
            loginPage.UserNameInput.SendKeys("standard_user");
            loginPage.PasswordInput.SendKeys("secret_sauce");
            loginPage.ButtonLog.Click();
        }
    }
}
