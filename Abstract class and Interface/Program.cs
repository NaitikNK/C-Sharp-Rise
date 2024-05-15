    using System;

namespace Abstract_class_and_Interface
{
    internal class Program
    {
        public abstract class A
        {
           public abstract void show();

            
        }
        public class B : A
        {
            public override void show()// use override because method is override from class A
            {
                Console.WriteLine("show method from class B");
            }
        }
        public class C : A
        {
            public override void show()// use override because method is override from class A
            {
                Console.WriteLine("show method from class C");
            }
        }
        public interface Name
        {
           void nik();
            
            int i
            {
                get;
                set;
            }
        }
        public interface Surname
        {
            void kp();
        }
        //Same method name in different interface it is called Explicit
        public interface Surname1
        {
            void kp();
        }
        public abstract class Naitik: Name
        {
            // You cannot call this method because you can not call directly abstract class
            //to call abstract class you have to inherit to another class 
            public void nik()
            {
                Console.WriteLine("nik method from class Naitik");
            }
            
        }

        public class Kapatel : Name, Surname, Surname1
        {
            public void nik()
            {
                Console.WriteLine("nik method from class Kapatel ");
            }
            //explicit interface have to define in class with proper name 
            void Surname.kp()
            {
                Console.WriteLine("kp method from interface surname");
            }
            void Surname1.kp()
            {
                Console.WriteLine("kp Method from interface surname1");
            }
        }

        static void Main(string[] args)
        {
            // create object from different class and make reference from different class
            A a1 = new B();
            a1.show();

            A a2 = new C();
            a2.show();

            //Interface class
            Console.WriteLine("\nInterface class and method");
            
            Console.WriteLine("\nLoose Coupling\n");    
            //Loose Coupling
            Name n1= new Kapatel();
            n1.nik();

            //while calling explicit interface have to define this way
            Surname s1 = new Kapatel();
            ((Surname) s1).kp();
            ((Surname1) s1).kp();

            Console.WriteLine("\nTight Coupling\n");

            //Tight Coupling
            Kapatel k1 = new Kapatel();
            k1.nik();
            k1.kp();


            //call property I
            Console.WriteLine("\nCall property from interface\n");

        }

    }
}
