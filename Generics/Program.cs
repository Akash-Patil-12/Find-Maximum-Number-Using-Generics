using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMax<int> findMax = new FindMax<int>(20, 30, 50);
            Console.WriteLine("Maximum value between 3 Integer is :"+ findMax.MaximumValue());
            FindMax<double> findMaxDouble = new FindMax<double>(30.12, 40.23, 50.12);
            Console.WriteLine("Maximum value between 3 Double is :" + findMaxDouble.MaximumValue());
            FindMax<string> findMaxString = new FindMax<string>("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum value between 3 String is :"+ findMaxString.MaximumValue());
        }
    }
}
