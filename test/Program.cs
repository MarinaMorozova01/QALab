using System;

namespace test
{
    class Program
    {
        public static void Koki(int a,int b)
        {
            if (a>b)
            {
                Console.WriteLine($"Value: {a} is greater than Value: {b} ");
            }
            else if (b>a)
            {
                Console.WriteLine($"Value: {b} is greater than Value: {a} ");

            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();

            int a = random.Next();
            int b = random.Next();

            Koki(a,b);


            
        }
    }
}
