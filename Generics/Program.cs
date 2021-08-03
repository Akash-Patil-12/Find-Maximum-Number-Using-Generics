using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMax findMax = new FindMax();
            Console.WriteLine("Maximum string is:"+findMax.MaximumString("Apple","Peach","Banana"));
        }
    }
}
