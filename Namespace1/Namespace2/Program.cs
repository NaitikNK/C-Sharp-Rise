using System;
using Classlib;
using Namespace1;
using nik;

namespace Namespace2
{

    interface IA
    {
        void Amethod();
    }
    class A : IA
    {
        public void Amethod()
        {
            Console.WriteLine("A");
        }
    }
    interface IB
    {
        void Bmethod();
    }
    class B:IB
    {
        public void Bmethod()
        {
            Console.WriteLine("B");
        }
    }
    //in this class AB cannot have multiple base classes (inheritance)
    //have to inherit from interface name in this
    class AB : IA,IB
    {
        public void Amethod()
        {
            Console.WriteLine("A");
        }
        public void Bmethod()
        {
            Console.WriteLine("B");
        }
    }





    //class C: A
    //{
    //    public void mymethod()
    //    {
    //        Console.WriteLine(k);
    //        Console.WriteLine(m);
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {

            //B b1=new B();
            //b1.add();

            //A a1= new A();
            //a1.show();
            //Console.WriteLine(a1.i);            

            //C c1= new C();
            //c1.mymethod();    

            /////////////////

            //A a2=new A();
            //a2.Amethod();
            //B b2=new B();
            //b2.Bmethod();

            Console.WriteLine("Call from interface");

            AB ab1 = new AB();
            ab1.Bmethod();
            ab1.Amethod();

            //class library both class method call
            Console.WriteLine("Library");
            Class2 c1 = new Class2();
            c1.lib(50);
            c1.lib2();           

        }
    }
}
