// Written by Swaroop Sapkota
// 02/13/2025
// Create a function that counts how many D's are in a sentence

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCounter
{
    public class Counter
    {
        public static int CountDs(string sentence)
        {
            int count = 0;
            string lowerSentence = sentence.ToLower();

            for(int i = 0; i < sentence.Length; i++)
            {
                if (lowerSentence[i] == 'd')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
