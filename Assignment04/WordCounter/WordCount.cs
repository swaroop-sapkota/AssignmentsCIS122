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
    public class WordCount
    {
        public static int countWords(string word)
        {
            int count = 0;
            bool inWord = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }

            }
            return count;
        }
    }
}
