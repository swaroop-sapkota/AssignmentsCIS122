// Written By Swaroop Sapkota
// 01/16/2025
// Create a method that takes a string and returns the word count.
// The string will be a sentence.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    public class Program01
    {
        static void Main(string[] args)
        {
            int noOfWords = WordCount.countWords("What an easy task, right");
            Console.WriteLine(noOfWords);
        }
    }
}
