using System;

namespace Prec_delegate
{   
    //create without argument delegate method
    public delegate void delmethod();

    //argument delegate
    public delegate void delmethod1(int x,int y);

    public class A
    {
        public static void show()
        {
            Console.WriteLine("show method");
        }
        public static void hide() 
        {
            Console.WriteLine("hide method");
        }
        public void display()
        {
            Console.WriteLine("display method");
        }
    }-
    public class B
    {
        public static void show1(int x, int y)
        {
            Console.WriteLine("show1 method from class B");
            Console.WriteLine(x+y); 
        }
        public static void hide1(int x,int y)
        {
            Console.WriteLine("hide 1 method from class B");
            Console.WriteLine(x-y);
        }        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //without argument delegate
            Console.WriteLine("Without Argument Delegates\n");
            delmethod del1 = A.show;

            delmethod del2= new delmethod(A.hide);

            A obj = new A();            
            delmethod del3 = obj.display;

            del1();
            del2();
            del3();

            //with argument delegate
            Console.WriteLine("With Argument Delegates\n");

            B b1=new B();

            delmethod1 ar1 = new delmethod1(B.show1);
            ar1 += new delmethod1(B.hide1);

            ar1(15,20);
            

            ar1 -= new delmethod1(B.hide1);

            ar1(15, 20);
            Console.ReadLine(); 
        }
    }
}
