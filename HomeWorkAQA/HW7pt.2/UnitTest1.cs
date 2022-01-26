using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static OpenQA.Selenium.By;

namespace HW7pt._2
{
    public class Tests
    {
        public IWebDriver _driver2;
        
        [OneTimeSetUp]
        public void OneTimeSetup2()
        {
            _driver2 = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver2.Navigate().GoToUrl(" https://www.calc.ru/kalkulyator-kalorii.html");
            _driver2.Manage().Window.Maximize();
        }  
        
        [Test]
        public void Test()
        {
            DefaultWait<IWebDriver> fluentW = new DefaultWait<IWebDriver>(_driver2);
            fluentW.Timeout = TimeSpan.FromSeconds(15);
            IWebElement dropDown = fluentW.Until(ExpectedConditions.ElementToBeClickable(By.Id("activity")));
            SelectElement selectElement = new SelectElement(dropDown);
            selectElement.SelectByText("5 раз в неделю");
                       
            IWebElement age = fluentW.Until(ExpectedConditions.ElementToBeClickable(By.Id("age")));
            age.Click();
            age.SendKeys("35");
        
            IWebElement weight = fluentW.Until(ExpectedConditions.ElementToBeClickable(By.Id("weight")));
            weight.Click();
            weight.Clear();
            weight.SendKeys("85"+Keys.Tab);
        
            IWebElement growth = fluentW.Until(ExpectedConditions.ElementToBeClickable(By.Id("sm")));
            growth.Click();
            growth.SendKeys("185");
            
            IWebElement submit = fluentW.Until(ExpectedConditions.ElementToBeClickable(By.Id("submit")));
            submit.Click();
            System.Threading.Thread.Sleep(10000);

            IWebElement result = fluentW.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//td[contains(text(), '3028 ккал/день')]")));
            Assert.AreEqual("3028 ккал/день", result.Text);
        }
        [TearDown]
        public void TearDown()
        {          
                _driver2.Quit();          
        }
    }
}