using System;
using ClassLib;
using Naitik.Kapatel;//adding new namespace to current project


//create namespace to difference in one project
namespace Naitik
{
    class J
    {
        public int r;

        public void show()
        {
            Console.WriteLine("" + r);
        }

    }

    namespace Kapatel
    {
        class N
        {
            int k = 10;

            public N(int k)
            {
                this.k = k;

            }
            public void nik()
            {
                Console.WriteLine("Value of k " + k);
            }
        }
    }
}


namespace Class_Practice_Project
{
    public class Program
    {
        class A
        {
            int i;

            //use this keyword
            //create constructor
            public A(int i)
            {
                this.i = i;
            }
            //show method
            public void show()
            {
                Console.WriteLine("Value of i = " + i);
            }
            //making Destructor
            ~A()
            {
                //clean up code
            }
        }
        public class Z
        {

        }
            static void Main(string[] args)
            {


                A a1 = new A(20);
                a1.show();



                //Naitik namespace object create
                N n1 = new N(20);
                n1.nik();

                //call library from different project via add reference in this project
                Console.WriteLine("\nLibrary called from different project");
                Class1 c1 = new Class1();
                c1.y = 50;
                //c1.lib(10, 20);
                Console.WriteLine("\nLibrary called " + c1.y);                

                //call second class from library and it can inherit class 1 
                Class2 c2 = new Class2();
                c2.lib2();
                c2.lib(10, 20);


                

            }
        }
    }
}
