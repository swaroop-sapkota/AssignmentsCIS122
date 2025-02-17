// Written By Swaroop Sapkota
// 01/16/2025
// Create a function that takes a string and returns a new string with its first and last characters swapped.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_New_String
{
    public class Program02
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NewString.flipEndChars("Cat, dog, and mouse.")); 
            Console.WriteLine(NewString.flipEndChars("ada")); 
            Console.WriteLine(NewString.flipEndChars("Ada")); 
            Console.WriteLine(NewString.flipEndChars("z"));
        }
    }
}
