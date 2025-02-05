// Written by Swaroop Sapkota
// 02/04/2025
// The Magic Cannon

using System;

namespace TheMagicCannon
{
    public class Program
    {
        static void Main(string[] args)
        {
            BlastTypeDeterminer blastChecker = new BlastTypeDeterminer();

            blastChecker.DisplayBlasts();

            Console.ReadLine();
        }
    }
}
