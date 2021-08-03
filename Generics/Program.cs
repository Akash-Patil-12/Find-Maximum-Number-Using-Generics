using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 20, 30, 50,10 };
            FindMax<int> findMax = new FindMax<int>(intArray);
            Console.WriteLine("Maximum value between Integer is :"+ findMax.MaximumValue());
            double[] doubleArray = { 11.23,30.12, 40.23, 50.12 };
            FindMax<double> findMaxDouble = new FindMax<double>(doubleArray);
            Console.WriteLine("Maximum value between Double is :" + findMaxDouble.MaximumValue());
            string[] stringArray = { "Apple", "Peach", "Banana","Mango" };
            FindMax<string> findMaxString = new FindMax<string>(stringArray);
            Console.WriteLine("Maximum value between String is :"+ findMaxString.MaximumValue());
        }
    }
}
