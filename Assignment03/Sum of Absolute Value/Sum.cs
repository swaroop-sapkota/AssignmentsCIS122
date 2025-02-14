// Written by Swaroop Sapkota
// 02/13/2025
// Return the sum of the absolute value of each element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAbsoluteValue
{
    public class Sum
    {
        public static int getAbsSum(int[] arr)
        {
            int sum = 0;
            int absValue;

            for(int i = 0; i < arr.Length; i++ )
            {
                if (arr[i]<0)
                {
                    absValue = -arr[i];
                }
                else
                {
                    absValue = arr[i];
                }

                sum += absValue;
            }

            return sum;
        }
    }
}
