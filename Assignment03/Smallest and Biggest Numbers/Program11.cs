using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestAndBiggest
{
    public class Program11
    {
        static void Main(string[] args)
        {
            int[] myExample = { 1, 4532, 7, 56, 24, -1, 56, 2, 52, 543, 23 };
           

            int[] output = MinMax.FindNums(myExample);

            Console.WriteLine("Min: " + output[0]);
            Console.WriteLine("Max:" + output[1]);
        }
    }
}
