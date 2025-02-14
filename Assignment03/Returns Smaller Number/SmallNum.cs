// Written by Swaroop Sapkota
// 02/13/2025
// Create a function that returns the smaller number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerNumber
{
    public class SmallNum
    {
        public static string ReturnSmallNum(string num1, string num2)
        {
            if (num1.Length < num2.Length)
            {
                return num1;
            }
            else if(num1.Length > num2.Length)
            {
                return num2;
            }

            for(int i = 0; i < num1.Length; i++)
            {
                if (num1[i] < num2[i])
                {
                    return num1;
                }
                else if(num1[i] > num2[i])
                {
                    return num2;
                }

            }

            return num1;
        }
    }
}
