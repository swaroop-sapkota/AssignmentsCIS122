// Written by Swaroop Sapkota
// 02/13/2025
// Create a function to multiply all of the values in an array
// by the amount of values in the given array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sLength
{
    public class ModifiedArray
    {
        public static int[] MultiplyByLength(int[] arr)
        {
            int length = arr.Length;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = arr[i] * length;
            }

            return result;
        }

    }
}
