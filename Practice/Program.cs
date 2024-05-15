using System;
using Class_Practice_Project;
namespace Practice
{
    internal class Program
    {
            //use params keyword
            public static void show(params int[] Numbers)
            {
                Console.WriteLine("There are {0} elements",Numbers.Length);
                        
            }
        
        //interface class
        interface A
        {
           static int a;
           public void I();
        }
        class B : A
        {
            public void I()
            {
                Console.WriteLine("\nI method from B class");
            }
        }
        class C : A
        {
            public void I()
            {
                Console.WriteLine("\nI method from C class");
            }
        }

        //create struct
        //this work same as class just only few things are different
        public struct X
        {                
            
            public void Y(int i)
            {
                i = 150;
            }

            public void  show(int i)
            {
                 Console.WriteLine("\nStruct interface = "+i);
            }
           
        }

        static void Main(string[] args)
        {
            
            int [] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            
            //don't need to make object to call because of params keyword
            show(Numbers);


            //interface
            Console.WriteLine("\nInterface class");

            Console.WriteLine("\nTight Coupling");
            B b=new B(); //tight coupling
            b.I();

            Console.WriteLine("\n\nLoose Coupling");
            A a = new B(); //loose coupling
            a.I();

            A a1=new C();
            a1.I();

            Class_Practice_Project.Program.Z z1 = new Class_Practice_Project.Program.Z(); 

            //create object of struct and call by reference 
            X x1=new X();
            x1.show(160);            
        }
    }
}
