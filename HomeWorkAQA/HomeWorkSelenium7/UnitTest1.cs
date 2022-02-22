using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static OpenQA.Selenium.Support.UI.WebDriverWait;
using System.Linq;
using System.Threading.Tasks;
using static OpenQA.Selenium.By;
using System;

namespace HomeWorkSelenium7
{
    public class Tests
    {
        public IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl("https://calc.by/building-calculators/laminate.html");
            _driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep(10000);
            js.ExecuteScript("window.scrollBy(0,1000);");
        }

        [Test]
        public void Test()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(_driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(15);

            IWebElement option = fluentWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("laying_method_laminate")));
            SelectElement selectElement = new SelectElement(option);
            selectElement.SelectByText("с использованием отрезанного элемента");

            IWebElement lenghtRoom = fluentWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("ln_room_id")));
            lenghtRoom.Click();
            lenghtRoom.Clear();
            lenghtRoom.SendKeys("500");

            IWebElement widthRoom = fluentWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("wd_room_id")));
            widthRoom.Click();
            widthRoom.Clear();
            widthRoom.SendKeys("400");

            IWebElement lenghtPanel = fluentWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("ln_lam_id")));
            lenghtPanel.Click();
            lenghtPanel.Clear();
            lenghtPanel.SendKeys("2000");

            IWebElement widthPanel = fluentWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("wd_lam_id")));
            widthPanel.Click();
            widthPanel.Clear();
            widthPanel.SendKeys("200");

            IWebElement direction = fluentWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("direction-laminate-id1")));
            direction.Click();

            IWebElement calculate = fluentWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@class='calc-btn']")));
            calculate.Click();
            System.Threading.Thread.Sleep(10000);

            IWebElement calcResult1 = _driver.FindElement(By.XPath("//div[contains(text(),'“ребуемое количество досок ламината:')]"));
            Assert.AreEqual("“ребуемое количество досок ламината: 53", calcResult1.Text);
            System.Threading.Thread.Sleep(10000);

            IWebElement calcResult2 = _driver.FindElement(By.XPath("//div[contains(text(),' оличество упаковок ламината:')]"));
            Assert.AreEqual(" оличество упаковок ламината: 7", calcResult2.Text);
        }

        [TearDown]
        public void TearDown()
        {
            //_driver.Quit();
        }
    }
}