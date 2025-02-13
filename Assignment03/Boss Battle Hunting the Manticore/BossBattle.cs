// Written by Swaroop Sapkota
// 02/11/2025
// Boss Battle Hunting the Manticore

using System;

namespace HuntingTheManticore
{
    public class BossBattle
    {
        private int manticoreDistance;
        private int manticoreHealth = 10;
        private int cityHealth = 15;
        private int round = 1;

        public void StartGame()
        {
            AskManticoreDistance();
            RunGame();
        }

        // Method to ask Player 1 to choose the Manticore's distance
        private void AskManticoreDistance()
        {
            Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");

            string input = Console.ReadLine();
            manticoreDistance = Convert.ToInt32(input);
            while (manticoreDistance < 0 || manticoreDistance > 100) 
            {
                Console.Write("Invalid input. Please enter a number between 0 and 100: ");
                input = Console.ReadLine();
                manticoreDistance = Convert.ToInt32(input);
            }

            Console.Clear(); 
        }

        // Method to run the game in a loop
        private void RunGame()
        {
            while (manticoreHealth > 0 && cityHealth > 0)
            {
                DisplayStatus();

                int damage = CalculateDamage();
                Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

                Console.Write("Enter desired cannon range: ");
                int target = GetTarget();

                TypeShot(target, damage);

                if (manticoreHealth > 0)
                {
                    cityHealth--;
                }

                round++;
            }

            DisplayOutcome();
        }

        // Method to display the round number, the city's health, and the Manticore's health.
        private void DisplayStatus()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine($"STATUS: Round {round} | City: {cityHealth}/15 | Manticore: {manticoreHealth}/10");
        }

        // Method to calculate the damage the cannon will deal.
        private int CalculateDamage()
        {
            if (round % 3 == 0 && round % 5 == 0)
            {
                return 10;
            }
            else if (round % 3 == 0 || round % 5 == 0)
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }

        // Method to determine the tpe of shot
        private void TypeShot(int target, int damage)
        {
            if (target > manticoreDistance)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That round OVERSHOT the target.");
                Console.ResetColor();
            }
            else if (target < manticoreDistance)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("That round FELL SHORT of the target.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That round was a DIRECT HIT!");
                Console.ResetColor();
                manticoreHealth -= damage;
            }
        }

        // Method to diaplay outcome
        private void DisplayOutcome()
        {
            if (manticoreHealth <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas is saved!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("The city has been destroyed! The Manticore is victorious.");
                Console.ResetColor();
            }
        }
        
        // Method to get the target range.
        private int GetTarget()
        {
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            while (number < 0 || number > 100)
            {
                Console.Write("Invalid input. Enter a number between 0 and 100: ");
                input = Console.ReadLine();
                number = Convert.ToInt32(input);
            }
            return number;
        }

    }
}
