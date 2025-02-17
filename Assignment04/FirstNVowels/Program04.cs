// Written By Swaroop Sapkota
// 02/16/2025
// Write a function that returns the first n vowels of a string.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNVowels
{
    public class Program04
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnVowels.firstNVowels("sharpening skills", 3));
            Console.WriteLine(ReturnVowels.firstNVowels("major league", 5));
            Console.WriteLine(ReturnVowels.firstNVowels("hostess", 5));
        }
    }
}
