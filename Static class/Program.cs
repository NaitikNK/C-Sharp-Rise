using System;

namespace Static_class
{
    class A
    {
        public int i = 30;

        // static constructor
        //you cannot call in main method
        static A()
        {
            int j = 20;   

        }
        //static method
        //you can call in main and give value while calling
        public static void show(int j)
        {
              

        }
        //public constructor
        //you can call in main method
        public A(int h)
        {
            h = i;
        }

        // public method
        public void display(int h)
        {
            
        }

    }
    //SECOND TIME
    class C
    {
        public int n = 100;

        static C()
        {
            int j = 20;
        }
        public static void show(int n)
        {


        }

        public C(int g)
        {
            g = 15;
        }
        public void display(String s)
        {

        }

    }

    //for property
    class B
    {
        public int n = 100;

        //public property read and write
        public String Y
        {
            get;
            set;
        }

        public int s = 55;
        //read only property
        public int X 
        {
            get
            {
                return s;
            }

        }

       //static property
       public static int W
        {
            get;
            set;

        }
    }


  
    internal class Program
    {
        static void Main(string[] args)
        {

          A a1 = new A(30);// constructor call by value

         Console.WriteLine("constructor value= "+a1.i); 
         Console.WriteLine("\n");

            //method call by value[static method]
            A.show(50);//method call

             //method call by reference [public method]
            a1.display(100); //call by reference


            
            B b1 = new B();

            //SECOND TIME
            C c1 = new C(16);

            C.show(18);

            c1.display("Patel");
            Console.WriteLine(c1.n);


            //property
            //value assine in property
            b1.Y = "Naitik";
            Console.WriteLine("Property = "+b1.Y);

            //readonly property
            Console.WriteLine("readonly property = "+b1.X);

            //static property
            B.W = 125;
            Console.WriteLine("Static property = "+B.W);

            //call by ref
            Console.WriteLine("\n");
            Console.WriteLine("ref use");
            int i = 10;
            
            static void modify(ref int i)
            {
                i = i + 10;
            }
           

            modify(ref i);
            Console.WriteLine("ref value = "+i);
        
        }
    }
}
