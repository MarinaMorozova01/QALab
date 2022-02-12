using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PageObject
{
    class LoginPage: BasePage
    {
        private static string END_POINT = "";

        private static readonly By UserNameInputBy = By.Id("user-name");
        private static readonly By PasswordInputBy = By.Id("password");
        private static readonly By ButtonLogBy = By.Id("login-button");

        public LoginPage(IWebDriver Driver,bool OpenPageByUrl): base(Driver,OpenPageByUrl)
        {
        }

        public LoginPage(IWebDriver Driver) : base(Driver, false)
        {
        } 

        protected override void OpenPage()
        {
            _driver.Navigate().GoToUrl(BaseTest.BaseURL+ END_POINT);
        }

        public override bool IsPageOpened() // Запихнуть сюда Wait ,который будет ждать пока кнопка логина будет видна
        {
            try
            {
                return ButtonLog.Displayed;
            }
            catch (Exception exception)
            {
                return false;
            }          
        }

        public IWebElement UserNameInput => _driver.FindElement(UserNameInputBy);
        public IWebElement PasswordInput => _driver.FindElement(PasswordInputBy);
        public IWebElement ButtonLog => _driver.FindElement(ButtonLogBy);       
    }
}
