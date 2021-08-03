using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMax findMax = new FindMax();
            Console.WriteLine("Maximum number is:"+findMax.MaximumFloatNumber(29.34, 40.34, 70.54));
        }
    }
}
