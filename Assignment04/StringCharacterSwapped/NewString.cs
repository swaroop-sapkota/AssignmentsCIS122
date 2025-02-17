// Written By Swaroop Sapkota
// 01/16/2025
// Create a function that takes a string and returns a new string with its first and last characters swapped.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_New_String
{
    public class NewString
    {
        public static string flipEndChars(string str)
        {
            int length = str.Length;

            if (length < 2)
            {
                return "Incompatible.";
            }

            if (str[0] == str[length - 1])
            {
                return "Two's a pair.";
            }

            char first = str[0];
            char last = str[length - 1];

            return last + str.Substring(1,length - 2) + first;
              
        }
    }
}
