using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Waits
{
    class Test3:BaseTest
    {
        private IWebDriver _driver;

        private static readonly By SearchFieldBy = By.XPath("//input[@class='fast-search__input']");
        private static readonly By IFrameBy = By.XPath(" //iframe[@class='modal-iframe']");
        private static readonly By FirstElementBy = By.XPath("(//a[@class='product__title-link'])[1]");
        private static readonly By FrameSearchBy = By.XPath("//input[@class='search__input']");
        private static readonly By ToasterBy = By.XPath("//h1['Тостер Philips HD2581/00']");

        [SetUp]
        public void SetUp()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl(BaseURL3);
            _driver.Manage().Window.Maximize();
        }
        
        [Test]
        public void Test()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            IWebElement SearchField = _driver.FindElement(SearchFieldBy);
            SearchField.Click();
            SearchField.SendKeys("Тостер");

            IWebElement IFrame = wait.Until(ExpectedConditions.ElementIsVisible(IFrameBy));
            _driver.SwitchTo().Frame(IFrame);

            IWebElement FirstElement = wait.Until(ExpectedConditions.ElementIsVisible(FirstElementBy));
            string elementText=FirstElement.Text;
            Assert.AreEqual("Тостер Philips HD2581/00", elementText);

            IWebElement FrameSearch = wait.Until(ExpectedConditions.ElementToBeClickable(FrameSearchBy));
            FrameSearch.Click();
            FrameSearch.Clear();
            FrameSearch.SendKeys(elementText);

            FirstElement.Click();

            IWebElement Toaster = wait.Until(ExpectedConditions.ElementIsVisible(ToasterBy));
            string toasterAssert=Toaster.Text;
            Assert.AreEqual("Тостер Philips HD2581/00", toasterAssert);
        }
        
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
