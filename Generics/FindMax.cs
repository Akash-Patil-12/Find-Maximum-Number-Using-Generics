using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
public class FindMax
    {
        /// <summary>
        /// Display maximum string
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <param name="thirdString"></param>
        /// <returns></returns>
        public string MaximumString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
                return firstString;
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0)
                return secondString;
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0)
                return thirdString;
            return "";
        }
    }
}