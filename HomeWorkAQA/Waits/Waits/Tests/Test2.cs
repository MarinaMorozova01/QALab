using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using NLog;

namespace Waits
{
    class Test2:BaseTest
    {
        private static IWebDriver _driver;
        private Logger _logger = LogManager.GetCurrentClassLogger();

        private static readonly By AppleStoreBy = By.XPath("//a[@class='schema-filter__store-item schema-filter__store-item_apple']");
        private static readonly By GooglePlayBy = By.XPath("//a[@class='schema-filter__store-item schema-filter__store-item_google']");
        private static readonly By GPOnlinerBy = By.XPath("//button[@class=' LkLjZd ScJHi HPiPcc IfEcue  ']");
        private static readonly By MoreButtonBy = By.XPath("//a[@class='LkLjZd ScJHi U8Ww7d xjAeve nMZKrb  id-track-click ']");
        private static readonly By ASOnlinerBy = By.XPath("(//button[@class='link we-truncate__button'])[1]");
        private static readonly By AdvertisingBy = By.Id("div-gpt-ad-1634113052639-0");
        private static  By AllBy = By.XPath("//div[@class='ImZGtf mpg5gc']");

        [SetUp]
        public void Setup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl(BaseURL);
            _driver.Manage().Window.Maximize();         
        }

        [Test]
        public void Test1()
        {
            string main= _driver.CurrentWindowHandle;           
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            Assert.AreEqual(_driver.Title, "Телевизор купить в Минске");

            IWebElement AppleStore = _driver.FindElement(AppleStoreBy);
            AppleStore.Click();          
            
            IWebElement GooglePlay = _driver.FindElement(GooglePlayBy);
            GooglePlay.Click();
          
            foreach (string window in _driver.WindowHandles)
            {
                if (main != window)
                {
                    _driver.SwitchTo().Window(window);
                    break;
                }
            }

            Assert.AreEqual(_driver.WindowHandles.Count, 3);
           
            var GPOnliner = wait.Until(ExpectedConditions.ElementIsVisible(GPOnlinerBy));
            Assert.AreEqual(_driver.Title, "Приложения в Google Play – Каталог Onliner");
            IWebElement MoreButton = _driver.FindElement(MoreButtonBy);                      
            MoreButton.Click();

            IReadOnlyCollection<IWebElement> All = _driver.FindElements(AllBy);          
           
            foreach (var item in All)
            {
                _logger.Info(item);
            }

            _driver.SwitchTo().Window(_driver.WindowHandles[2]);
            IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,500);");

            IWebElement ASOnliner = wait.Until(ExpectedConditions.ElementIsVisible(ASOnlinerBy));
            ASOnliner.Click();
            Assert.AreEqual(_driver.Title, "Каталог Onliner on the App Store");
            _driver.Close();

            _driver.SwitchTo().Window(_driver.WindowHandles[0]);
            IWebElement Advertising = wait.Until(ExpectedConditions.ElementToBeClickable(AdvertisingBy));
            Advertising.Click();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
