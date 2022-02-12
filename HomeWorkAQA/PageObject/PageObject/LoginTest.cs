using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static OpenQA.Selenium.Support.UI.WebDriverWait;

namespace PageObject
{
    public class Tests : BaseTest
    {
        private IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Manage().Window.Maximize();
            LoginStep loginStep = new LoginStep(_driver);
            loginStep.LogIn();
        }

        [Test]
        public void TestLogin()
        {
            Assert.AreEqual(_driver.Title, "Swag Labs");
        }
        
        [Test]
        public void TestAllItems()
        {            
            Assert.IsTrue(new AllItemsPage(_driver,true).IsPageOpened());
            AllItemsStep1 allItemsStep = new AllItemsStep1(_driver);
            allItemsStep.AllItems();
            IWebElement var=allItemsStep.Remove();
            Assert.AreEqual(var.Text, "REMOVE");
        }

        [Test]
        public void TestProductPage()
        {
            ProductStep productStep = new ProductStep(_driver);
            IWebElement price = productStep.ProductAdd();
            Assert.AreEqual(price.Text, "$9.99");
        }

        [Test]
        public void TestCart()
        {
            CartStep cartStep = new CartStep(_driver);
            cartStep.CartCheckout();            
        }

        [Test]
        public void TestCartOne()
        {
            CartOneStep cartOneStep = new CartOneStep(_driver);
            cartOneStep.FieldsFilling();
        }

        [Test]
        public void TestCartTwo()
        {
            CartTwoStep cartTwoStep = new CartTwoStep(_driver);
            cartTwoStep.Finish();
        }






    }
}