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
    public class LetterChanger
    {
        public static string Move(string str)
        {
            string msg = "";

            foreach (char c in str)
            {
                char nextChar = (char)(c + 1);

                msg += nextChar;
            }
            return msg;
        }
    }
}
