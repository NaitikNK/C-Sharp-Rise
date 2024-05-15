
using System;

namespace Methods
{



    internal class Program
    {
        //Method Overloading
        //Method Overloading is same name with different number

        public static void show(params int[] args)
        {
            foreach (int arg in args)
            {
                Console.WriteLine(args[arg]);
            }
        }

        void display(int a)
        {
            Console.WriteLine(a);
        }
        void display(int a, int b)
        {
            Console.WriteLine("a " + a + ", " + b);
        }

        //Call by Reference
        static void modifyvalue(ref int num)
        {
            num = num * 10;
        }

        //Making of Constructor
        class Car
        {
            internal String brand;
            internal int price;

            //constructor
            internal Car(String thebrand, int theprice)
            {
                brand = thebrand;
                price = theprice;
            }
        }
        static void Main(string[] args)
        {

            //Method Overloading
            Program p = new Program();
            p.display(1); //call by value
            p.display(1, 2);

            //Initialization Constructor
            Car car1 = new Car("Suzuki", 500000);
            Console.WriteLine("\nMethod Overloading");
            Console.WriteLine("Brand = " + car1.brand);
            Console.WriteLine("Price = " + car1.price);

            //Call By Reference
            Console.WriteLine("\n Call By Reference");
            int num = 20;

            Console.WriteLine(num); //original value

            modifyvalue(ref num);
            Console.WriteLine(num); //Modify value by reference


        }
    }
}

