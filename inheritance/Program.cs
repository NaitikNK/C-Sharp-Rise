using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace inheritance
{

    class A
    {
        public int a;
        public int b = 13;

        public  A()
        {
            
            //Console.WriteLine("A value");
        }

        //use virtual and overriding 
        public virtual void show()
        {
            Console.WriteLine("Method from base A class");
        }
        
        
    }
    class B : A
     {
        public int c = 15;

        
        public override void show()
        {
            //base.show(); //use base keyword to call Base class
            Console.WriteLine("Method from derive B class");
        }

     }
    class E : A
    {
        public override void show()
        {
            Console.WriteLine("Mehtod from E class");
        }
    }
        
    class C : B
    {
        
        public override void show()
        {
                
            Console.WriteLine("Method from C class");
        }

    }

    // In abstract class you can't make object and call
    // for abstract class have to make inheritance 

    abstract class nk
    {               

        public void na()
        {
            Console.WriteLine("Method from nk class");
        }
            
    }
    class kp : nk
    {
       public void ka()
        {
            Console.WriteLine("Method from kp class");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            A a1 = new B();
            A a2 = new E();
            a1.show(); // to call method from both class
            a2.show();

            //B b1 = new B();
            //b1.show();

            //Console.WriteLine("Class A constructor value = "+b1.a);
            //Console.WriteLine("Class A int B value= "+b1.b);

            // Console.WriteLine(b1.c);

            //Poly
            Console.WriteLine("\nPoly");

            B a3 = new C();
            a3.show();
            A a4 = new C();
            a4.show();

            //Abstract class
            Console.WriteLine("\nAbstract Class");

            kp p1 = new kp(); 
            p1.na(); //call abstract class from derive class object
            p1.ka();    


        }
    }
}
