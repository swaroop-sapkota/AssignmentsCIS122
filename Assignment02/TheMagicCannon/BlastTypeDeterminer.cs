// Written by Swaroop Sapkota
// 02/04/2025
// The Magic Cannon

using System;

namespace TheMagicCannon
{
    public class BlastTypeDeterminer
    {
        // Method to identify and display blast types
        public void DisplayBlasts()
        {
            for (int i = 1; i <= 100; i++) 
            {
                string blastType;
                ConsoleColor originalColor = Console.ForegroundColor; 

                // Check Fire & Electric first
                if (i % 3 == 0 && i % 5 == 0)
                {
                    blastType = "Fire & Electric";
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (i % 3 == 0)
                {
                    blastType = "Fire";
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (i % 5 == 0)
                {
                    blastType = "Electric";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    blastType = "Normal";
                    Console.ForegroundColor = originalColor;
                }

                // Print the result
                Console.WriteLine($"{i}: {blastType}");

                // Reset color to original
                Console.ForegroundColor = originalColor;
            }
        }
    }
}
