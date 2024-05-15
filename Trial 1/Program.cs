using System;
using System.Globalization;

namespace Trial_1
{
    class Program
    {
        //Enum program value initialization
        enum level
        {
            Tiger,
            Bird,
            Animal
        }

        static void Main(string[] args)
        {
            int i = 10;
            float j = 5;
            String color = "red";

            //type casting convert int to string
            Console.WriteLine("Typecasting Program\n");
            Console.WriteLine(i.GetType());

            Console.WriteLine(Convert.ToString(i));
            Console.WriteLine(Convert.ToString(i).GetType());

            Console.WriteLine("\n");

            //converting float to int
            Console.WriteLine(j.GetType());

            Console.WriteLine(Convert.ToInt32(j));
            Console.WriteLine(Convert.ToInt32(j).GetType());

            Console.WriteLine("\n");

            //Boxing Program 

            int num = 100;

            //boxing
            //create object
            object obj = num;

            Console.WriteLine("Boxing Program");

            //value of num change
            num = 200;

            Console.WriteLine(num);

            Console.WriteLine("\n");
            //Unboxing Program
            int t = 100;

            Console.WriteLine("Unboxing Program");

            object obb = t;

            Console.WriteLine(obb);
            Console.WriteLine("\n");

            //Enum Program
            Console.WriteLine("Enum Program");
            level h= level.Tiger;
            Console.WriteLine(h);


        }
    }
}

