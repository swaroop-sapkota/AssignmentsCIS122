// Written by Swaroop Sapkota
// 02/16/2025
// Create a function that takes a string and returns true or false, 
// depending on whether the characters are in order or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterOrderCheck
{
    public class Program03
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CharOrderCheck.IsInOrder("abc"));
            Console.WriteLine(CharOrderCheck.IsInOrder("edabit"));
            Console.WriteLine(CharOrderCheck.IsInOrder("123"));
            Console.WriteLine(CharOrderCheck.IsInOrder("xyzz"));

        }
    }
}
