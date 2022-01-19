using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HomeWork6_NUnit_
{
    [TestFixture]
    public class Tests
    {
        private Calculator _calculator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("OneTimeSetup....");
            _calculator = new Calculator();
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup....");
        }

        [Test]
        [Category("SmokeTest")]
        [Property("Priority",1)]
        public void TestSum()
        {
            Assert.AreEqual(13,  _calculator.Sum(5, 8));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestDif()
        {
            Assert.AreEqual(5, _calculator.Dif(20, 15));
        }

        [Test]
        [Category("SmokeTest")]
        public void TestProd()
        {
            Assert.AreEqual(40, _calculator.Prod(20, 2));
        }

        [Test]
        [Category("SmokeTest")]
        [Property("Priority", 2)]
        public void TestDiv()
        {
            Assert.AreEqual(2, _calculator.Div(20, 10));
        }

        [Test]
        [Category("Regression")]
        [Retry(2)]
        public void TestDivByZero()
        {
            Assert.Throws<DivideByZeroException>(delegate { _calculator.Div(20, 0); });
        }

        [Test]
        [Category("NewFeatureTest")]
        public void TestCondition()
        {
            Assert.Multiple(() =>
            {
                string str = "calculator is work";
                Assert.IsNotEmpty(str);
                List<string> person = new List<string>() {};
                Assert.IsEmpty(person);
            });
        }

        [Test]
        [Category("NewFeatureTest")]
        public void TestComparisons()
        {
            Assert.Multiple(() =>
            {
                int dif = _calculator.Dif(50,20);
                int sum = _calculator.Sum(10,15);
                Assert.Greater(dif, sum);
                int div = _calculator.Div(50,10);
                Assert.GreaterOrEqual(sum, div);
                Assert.LessOrEqual(sum, dif);              
            });
        }
        [Test]
        public void TestUtility()
        {
            int prod = _calculator.Prod(10, 4);
            if (prod<100)
            {
                Assert.Pass("Result is less than 100"); ;
            }
            else
            {
                Assert.Fail("Result is greater than 100");
            }
        }

        [Test]
        [Category("NewFeatureTest")]
        public void TestIdentity()
        {
            List<string> person = new List<string> { "Harry", "Ron", "Hermione" };
            Assert.Contains("Harry", person);
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown...");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("OneTimeTearDown...");
        }


    }
}