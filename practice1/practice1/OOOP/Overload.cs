using System;


namespace OOP
{
    public class Overload
    {
        #region Params

        public void DisplayParams()
        {
            DisplayOverload(100, "Sasha", "Tanya", "Sveta");
            DisplayOverload(200, "Sasha");
            //DisplayOverload(500);-(will not be output,because there is not enough parameter of type string or int)

            DisplayOverload(1000, 2000, 3000, 4000);
            DisplayOverload(750, 520);

            DisplayOverload(400, "Sasha", 4, "Hello", 78);

            string[] names = { "Work", "Shop", "Magazine" };
            DisplayOverload(100, names);

            int[] numbers = { 10, 20, 30 };
            DisplayOverload1(40, numbers);
            Console.WriteLine(numbers[1]);

            int number = 102;
            DisplayOverload(50, 1000, number, 5000);
            Console.WriteLine(number);

        }

        private void DisplayOverload(int a, params string[] parametrArray)
        {
            foreach (string str in parametrArray)
            {
                Console.WriteLine($"{str},{a}");
            }
        }

        private void DisplayOverload(int a, params int[] parametrArray)
        {
            foreach (int str in parametrArray)
            {
                Console.WriteLine($"{str},{a}");
            }
        }
        
        private void DisplayOverload(int a, params object[] parametrArray)
        {
            foreach (var str in parametrArray)
            {
                Console.WriteLine($"{str},{a}");
            }
        }
        
        private void DisplayOverload1(int a, params int[] parametrArray)
        {
            parametrArray[1] = 3000;
        }
        
        private void DisplayOverload(int x, int y)
        {
            Console.WriteLine("The two integers" + x + "" + y);
        }
        
        private void DisplayOverload(params int[] parametrArray)
        {
            Console.WriteLine("parametrArray");
        }
        #endregion

        #region (ref,out)
        private string _name = "Achil";
        
        private void Display2(ref string x, ref string y)
        {
            Console.WriteLine(_name);
            x = "Achil 1";
            Console.WriteLine(_name);
            y = " Achil 2";
            Console.WriteLine(_name);
            _name = "Achil 3";
        }
        
        public void Display()
        {
            Display2(ref _name, ref _name);
            Console.WriteLine(_name);
        }

        private void Display3(out string n, out string d)
        {
            n = "Hello";
            d = "world";
        }
        
        public void Display4()
        {
            Display3(out _name, out _name);
            Console.WriteLine(_name);
        }
        #endregion

        #region show
        private int _count = 0;

        public void Show(string m)
        {
            _count++;
            Console.WriteLine(m);
            Console.WriteLine($"method Show called {_count} times");
        }
        #endregion

        #region overload
        public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload int a={a}");
        }
        
        public void DisplayOverload(string s)
        {
            Console.WriteLine($"DisplayOverload string s={s}");
        }
        
        public void DisplayOverload(string s, int a)
        {
            Console.WriteLine($"DisplayOverload string s={s}, int a= {a}");
        }
        #endregion
    }

}
