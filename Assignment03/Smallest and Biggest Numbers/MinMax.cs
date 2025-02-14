﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestAndBiggest
{
    public class MinMax
    {
        //If you want this to be 'non-static', just remove the static keyword.
        public static int[] FindNums(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];

            foreach (int i in arr)
            {
                if (i < min) { min = i; }
                if (i > max) { max = i; }
            }

            return new int[] { min, max };
        }
    }
}
