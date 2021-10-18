using System;


namespace ооп
{
    #region Class for Inheritance
    abstract class A
    {
        public void DoIt()
        {
            Console.WriteLine("Do some work");
        }

        public abstract void Xyz();
    }
    class B : A
    {
        public void Test1()
        {
            Console.WriteLine("Try to do somethink");
            DoIt();
        }
        public override void Xyz()
        {

        }
    }
    class C
    {
        //private A a = new A();
        public void Test2()
        {
            Console.WriteLine("Try to do somethink 2");
            //a.DoIt();
        }
    }
    #endregion
    class Program
    {
        static void adc(A a)
        {
            a.DoIt();
            a.Xyz();
        } // For Inheritance
        static void Main(string[] args)
        {
            #region Polymorphism
            var Overload = new Overload();
            #region (ref,out)
            Overload.Display();
            Overload.Display4();
            #endregion

            #region Params
            Overload.DisplayParams();
            #endregion

            #region Overload
            Overload.DisplayOverload(100);
            Overload.DisplayOverload("abc");
            Overload.DisplayOverload("hello", 19);
            #endregion

            #region Show
            Overload.Show("friend");
            Overload.Show("jhdfj");
            var Overload2 = new Overload();
            Overload2.Show("djkdj");
            #endregion
            #endregion

            #region Inheritance
            B b = new B();
            b.Test1();

            C c = new C();
            c.Test2();

            Console.WriteLine("/////////////////////////////////////////");

            // adc(new A());
            adc(b);

            A x = new B();
            x.DoIt();
            #endregion
        }
    }
}
