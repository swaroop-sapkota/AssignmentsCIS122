// Written by Swaroop Sapkota
// 01/30/2025
// The Dominion of Kings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionOfKings
{
    public class TheDominionOfKings
    {
        static void Main(string[] args)
        {

            List<KingdomScore> kings = new List<KingdomScore>();

            // Asking for user input

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter the number of provinces for King {i+1}: ");
                int provinces = Convert.ToInt32( Console.ReadLine() );

                Console.Write($"Enter the number of duchies for King {i+1}: ");
                int duchies = Convert.ToInt32( Console.ReadLine() );

                Console.Write($"Enter the number of estates for King {i+1}: ");
                int estates = Convert.ToInt32( Console.ReadLine() );

                kings.Add(new KingdomScore(provinces, duchies, estates));
            }
            
            // loop to display output

            foreach (var king in kings)
            {
                Console.WriteLine(king.ToString());
                Console.WriteLine("------------------------------------");
            }


        }
    }
}
