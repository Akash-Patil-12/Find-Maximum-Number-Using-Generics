using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
   public class FindMax<T> where T : IComparable
    {
        public T[] values;
        public T firstValue, secondValue, thirdValue;
        public FindMax(T[] values)
        {
            this.values = values;
        }
        /// <summary>
        /// Sort given array and return maximum value
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public T SortArray(T[] array)
        {
            Array.Sort(array);
            foreach(T item in array)
            {
                Console.WriteLine(item);
            }
            return array[array.Length-1];
        }
        /// <summary>
        /// Return maximum Value of given type 
        /// </summary>
        /// <returns></returns>
        public T MaximumValue()
        {
            T value =SortArray(values);
            return value;
        }
    }
}