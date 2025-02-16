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
    public class Program13
    {
        static void Main(string[] args)
        {
            int[] result = ModifiedArray.MultiplyByLength(new int[] { 2, 3, 1, 0 });
            Console.WriteLine(string.Join(", ", result));


        }
    }
}
