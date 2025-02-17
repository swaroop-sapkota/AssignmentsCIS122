// Written By Swaroop Sapkota
// 02/16/2025
// Write a function that changes every letter to the next letter

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Every_Letter_Changer
{
    public class Program05
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LetterChanger.Move("hello"));
            Console.WriteLine(LetterChanger.Move("bye"));
            Console.WriteLine(LetterChanger.Move("welcome"));
        }
    }
}
