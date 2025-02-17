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
    public class ReturnVowels
    {
        public static string firstNVowels(string str, int num)
        {
            string msg = "";
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i]== 'u')
                {
                    msg += str[i];
                }
            }

            if (msg.Length < num)
            {
                return "Invalid";
            }

            return msg.Substring(0, num);
        }
    }
}
