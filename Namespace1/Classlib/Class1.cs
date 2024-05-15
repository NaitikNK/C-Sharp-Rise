using System;
using System.Threading.Channels;

namespace Classlib
{
    public class Class1
    {

        public int i;

        public void lib(int i)
        {
            Console.WriteLine("Class lib method value = "+i);
        }

    }
    public class Class2 : Class1
    {
        public void lib2()
        {
            Console.WriteLine("lib2 method");
        }
    }
}
