using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using static OpenQA.Selenium.Support.UI.WebDriverWait;
using OpenQA.Selenium.Support.UI;

namespace PageObject
{
    public abstract class BasePage
    {
        [ThreadStatic] protected static IWebDriver _driver;
        protected abstract void OpenPage();
        public abstract bool IsPageOpened();
    
        public BasePage(IWebDriver Driver, bool OpenPageByUrl)
        {
            _driver = Driver;
            if (OpenPageByUrl)
            {
                OpenPage();   
            }
        }
    }
}
