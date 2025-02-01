// Written by Swaroop
// 01/30/2025
// The Defense of Consolas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseOfConsolas
{
    public class TheDefenseOfConsolas
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";

            Console.Write("Target Row? ");
            int targetRow = Convert.ToInt32(Console.ReadLine());

            Console.Write("Target Column? ");
            int targetColumn = Convert.ToInt32(Console.ReadLine());

            aDefenseOfConsolas defense = new aDefenseOfConsolas(targetRow, targetColumn);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Deploy to: ");
            Console.WriteLine(defense.ToString());

            
            Console.ForegroundColor = ConsoleColor.White;

            // Play a beep sound
            Console.Beep(1000,500);

        }
    }
}
