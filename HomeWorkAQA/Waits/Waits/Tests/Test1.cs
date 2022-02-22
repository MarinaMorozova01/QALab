using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System;

namespace Waits
{
    public class Tests : BaseTest
    {
        private static IWebDriver _driver;

        private static readonly By CheckBox1By = By.XPath("(//label[@class='schema-product__control'])[2]");
        private static readonly By CheckBox2By = By.XPath("(//label[@class='schema-product__control'])[3]");
        private static readonly By ComparisonButtonBy = By.XPath("(//div/a[@class='compare-button__sub compare-button__sub_main'])[1]");

        private static readonly By DiagonalBy = By.XPath("(//td/span[contains(text(),'Диагональ экрана')])[1]");
        private static readonly By DiagonalButtonBy = By.XPath("//div/span[@data-tip-term='Диагональ экрана']");
        private static readonly By DescriptionBy = By.XPath("//div[@class='product-table-tip__text']");
        private static readonly By DeleteButtonBy = By.XPath("(//a[@title='Удалить'])[3]");

        [SetUp]
        public void Setup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl(BaseURL);
            _driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,300);");
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(_driver.Title, "Телевизор купить в Минске");

            IWebElement CheckBox1 = _driver.FindElement(CheckBox1By);
            CheckBox1.Click();

            IWebElement CheckBox2 = _driver.FindElement(CheckBox2By);
            CheckBox2.Click();

            IWebElement ComparisonButton = _driver.FindElement(ComparisonButtonBy);
            ComparisonButton.Click();

            IJavaScriptExecutor js = _driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,400);");

            IWebElement Diagonal = _driver.FindElement(DiagonalBy);
            string diagonalText = Diagonal.Text;
            Assert.AreEqual("Диагональ экрана", diagonalText);
            Diagonal.Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            IWebElement DiagonalButton = wait.Until(_driver => _driver.FindElement(DiagonalButtonBy));
            DiagonalButton.Click();

            IWebElement Description = wait.Until(_driver => _driver.FindElement(DescriptionBy));
            DiagonalButton.Click();
            var Description2 = wait.Until(ExpectedConditions.InvisibilityOfElementLocated(DescriptionBy));

            js.ExecuteScript("window.scrollBy(0,-400);");

            IWebElement DeleteButton = _driver.FindElement(DeleteButtonBy);
            DeleteButton.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            Assert.AreEqual(_driver.Title, "Сравнить Samsung QE65LS01TBU");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}