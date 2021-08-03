using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMax findMax = new FindMax();
            Console.WriteLine("Maximum value between 3 Integer is :"+ findMax.MaximumValue(20, 30, 50));
            Console.WriteLine("Maximum value between 3 Floats is :" + findMax.MaximumValue(20.34, 70.34, 50.34));
            Console.WriteLine("Maximum value between 3 String is :"+ findMax.MaximumValue("Apple", "Peach", "Banana"));
        }
    }
}
