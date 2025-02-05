// Written by Swaroop Sapkota
// 02/04/2025
// The Replicator of D'To

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheReplicatorOfDTo
{
    public class Replicator
    {
        private int[] originalArray = new int[5];
        private int[] copiedArray = new int[5];

        // Method to get user input 

        public void GetUserInput()
        {
            Console.WriteLine("Enter 5 numbers: ");
            
            for (int i = 0; i < originalArray.Length; i++)
            {
                Console.Write($"Number {i+1}: ");
                originalArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Method to copy values from originalArray to copiedArray

        public void ReplicateArray()
        {
            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];  
            }
        }

        // Method to display both arrays
        public void DisplayArrays()
        {
            Console.WriteLine("\nOriginal Array: ");

            foreach(int num in originalArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nCopied Array: ");

            foreach (int num in copiedArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
