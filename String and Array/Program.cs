using System;

namespace Trial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Program 
            String i = "Hello World!";

            Console.WriteLine("String Program");

            Console.WriteLine("Length of string = " + i.Length);
            Console.WriteLine("Lower words in string = " + i.ToLower());
            Console.WriteLine("Upper words in string = " + i.ToUpper());

            Console.WriteLine("\n");

            //Array Program
            Console.WriteLine("Array Program");
            String[] name = { "Naitik", "Maulik", "Kirtan", "Ronak" };

            Console.WriteLine("Length of array = " + name.Length);

            Console.WriteLine("\n");
            //Array numeric Program
            String[] arr1 = { "1,2,3" };
            Console.WriteLine("Array Print = " + arr1[0]);

            Console.WriteLine("\n");
            int[,] arr2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine(arr2[2, 1]);

        }
    }
}
