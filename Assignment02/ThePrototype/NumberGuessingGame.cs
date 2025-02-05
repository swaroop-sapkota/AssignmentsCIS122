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
    public class NumberGuessingGame
    {
        // Class Variable
        private int target = -1;

        // Property
        public int Target
        {
            get { return this.target; }
            set { this.target = value; }
        }

        // Method to ask User 1 (Pilot) for the target number
        public void TargetNumber()
        {
            int number;
            do
            {
                Console.WriteLine("User 1, enter anumber between 0 and 100: ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < 0 || number > 100);

            this.Target = number;

            // Clear the screen
            Console.Clear();
        }

        // Method to guess the nuber
        public void Guesses()
        {
            Console.WriteLine("User 2, guess the number!");

            int guess;

            do
            {
                Console.WriteLine("What is you next guess? ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > this.Target)
                {
                    Console.WriteLine($"{guess} is too high.");
                }
                else if (guess < this.Target)
                {
                    Console.WriteLine($"{guess} is too low.");
                }
                else
                {
                    Console.WriteLine("You guessed the number!"); ;
                }
            } while (guess != this.Target);
        }

    }
}
