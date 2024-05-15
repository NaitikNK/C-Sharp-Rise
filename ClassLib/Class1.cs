using System;

namespace ClassLib
{
    public class Class1
    {                
        //create method inside library
        public void lib(int x, int z)

        {
            int n;
            n= x + z;
            Console.WriteLine("Method = "+n);
        }
        //create property inside library
        public int y
        {
            get;
            set;
        }
    }
    //class 2 inherit class 1 
    public class Class2 : Class1
    {
        public void lib2()
        {
            Console.WriteLine("\nclass 2 Method lib2\n");
        }
    }
}
