using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6_NUnit_
{
      class TestCase1:Calculator
    {
        [TestCase("Sum")]
        [TestCase("Div")]
        public void Test(string operation)
        {
            if (operation.Equals("Sum"))
            {
                int sum=Sum(5,5);
                Console.WriteLine($"Result of {operation} ={sum}");
            }
            else if (operation.Equals("Div"))
            {
                int div=Div(10, 5);
                Console.WriteLine($"Result of {operation} ={div}");
            }
            else
            {
                throw new NotImplementedException("Please, try again!");
            }

        }
    }
}
