using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 20, 30, 50,10 };
            FindMax<int> findMax = new FindMax<int>(intArray);
            findMax.PrintMaxValue();
            double[] doubleArray = { 11.23,30.12, 40.23, 50.12 };
            FindMax<double> findMaxDouble = new FindMax<double>(doubleArray);
            findMaxDouble.PrintMaxValue();
            string[] stringArray = { "Apple", "Peach", "Banana","Mango" };
            FindMax<string> findMaxString = new FindMax<string>(stringArray);
            findMaxString.PrintMaxValue();
        }
    }
}
