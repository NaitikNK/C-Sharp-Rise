using System;
using nik;

namespace nik
{    

    public class A
    {
        public int i = 10; //you can call in different program
        private int j=20; //you can't call in different program 
        protected int k=30; //you can call in different program
        internal int l=40; //you can't call in different program
        internal protected int m=50; // you can call in different program

        public void show()
        {

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine("namespace nik method");
        }
    }
   
}


namespace Namespace1
{

    public class B
    {
        public void add()
        {
            Console.WriteLine("Class B add method");
        }
    }

    internal class Program
    {        

        static void Main(string[] args)
        {
            
            A a = new A();
            a.show();


            B b = new B();
            b.add();
        }
    }
}
