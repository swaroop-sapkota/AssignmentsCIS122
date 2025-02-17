// Written by Swaroop Sapkota
// 02/16/2025
// Create a function that takes a string and returns true or false, 
// depending on whether the characters are in order or not.

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterOrderCheck
{
    public class CharOrderCheck
    {
        public static bool IsInOrder(string str)
        {

            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i] > str[i + 1])
                {
                    return false;
                }

            }
            return true;
        }
    }
}
