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
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, -1, -4, 9, 10 };

            int sum = Sum.getAbsSum(nums);
            Console.WriteLine(sum);

        }
    }
}
