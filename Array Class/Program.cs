using System;

namespace Array_Class
{
    class Program
    {


        enum animal
        {
            Tiger,
            Lion,
            Bird
        }

        static void Main(string[] args)



            int[] a = new int[5];
        int[] h = { 1, 2, 3, 4, 5 };
        int[,] b = new int[3, 2];

        int[,] k = { { 1, 2, 3 }, { 4, 5, 6 } };
                

            
           //1D Array 
            for (int i = 0; i<a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
              
            }

    Console.WriteLine("\n");

            for (int j = 0; j<h.Length; j++)
            {
                Console.WriteLine(h[j]);
            }

Console.WriteLine("\n");


//2D Array
for (int i = 0; i < b.Length; i++)
{
    for (int j = 0; j < b.Length; j++)
    {

    }
}


/*for(int i = 0;i < b.GetLength(0);i++)
{
    Convert.ToInt32(Console.ReadLine(i));
    for(int j= 0; j<b.GetLength(1); j++)
    {
        Convert.ToInt32(Console.ReadLine(i,j));
    }            
}*/



for (int i = 0; i < k.GetLength(0); i++)
{
    Console.WriteLine("Row " + i + ":");
    for (int j = 0; j < k.GetLength(1); j++)
    {
        Console.WriteLine(k[i, j] + " ");
    }
}

//Enum 
animal a = animal.Tiger;
Console.WriteLine(a);
            

        }
    }
}

