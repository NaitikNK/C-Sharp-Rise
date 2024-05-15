using System;

namespace Class_and_Property
{
    class A
    {
        public int i = 50;
        //create property
        public int Y
        {
            get;
            set;
        }
        //create constructor
        public A()
        {
            i = 12;
           
        }
        //parameterized constructor
        public A(int h)
        {
            i = h;
        }

    }
    internal class Program
    {

        public static void B(out int j)
        {
            j = 15;
        }


        static void Main(string[] args)
        {
            A a1 = new A();
            Console.WriteLine("simple define object  i = " + a1.i);
            Console.WriteLine("\n");

            //assine value in property value
            a1.Y = 100;
            Console.WriteLine("Property 'y' = " + a1.Y);
            Console.WriteLine("\n");

            //default constructor
            A a2 = new A();
            Console.WriteLine("Default constructor=" + a2.i);
            Console.WriteLine("\n");

            //parameterized constructor
            A a3 = new A(20);
            Console.WriteLine("parameterized constructor=" + a3.i);
            Console.WriteLine("\n");

            //out parameter output
            int j = 0;

            B(out j);

            Console.WriteLine("out keyword j value=" + j);
            Console.WriteLine("\n");


        }
    }
}

