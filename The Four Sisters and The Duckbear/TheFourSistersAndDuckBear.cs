// Written by Swaroop
// 01/29/2025
// The Four Sisters and the Duckbear

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSistersAndDuckbear
{
    public class TheFourSistersAndDuckBear
    {
        static void Main(string[] args)
        {
            EggDistributor eggDistributor = new EggDistributor();

            Console.Write("Enter the number of eggs: ");

            eggDistributor.NoOfEggs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(eggDistributor.ToString());

        }
    }
}
