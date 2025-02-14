using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestAndBiggest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] myExample = { 1, 4532, 7, 56, 24, -1, 56, 2, 52, 543, 23 };
            //If FindNums were not static, then it would look something like this:
            /*
             * Solution solver = new Solution();
             * int[] output = solver.FindNums(myExample);
             */

            int[] output = MinMax.FindNums(myExample);

            Console.WriteLine("Min: " + output[0]);
            Console.WriteLine("Max:" + output[1]);
        }
    }
}
