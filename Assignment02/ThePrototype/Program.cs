// Written by Swaroop Sapkota
// 02/04/2025
// The Prototype

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            NumberGuessingGame game = new NumberGuessingGame();

            game.TargetNumber();

            game.Guesses();

            Console.ReadLine();
        }
    }
}
