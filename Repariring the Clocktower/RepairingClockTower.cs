// Written by Swaroop
// 01/30/2025
// Repairing the Clocktower

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTower
{
    public class RepairingClockTower
    {
        static void Main(string[] args)
        {
            RepClockTower repClockTower = new RepClockTower();

            Console.Write("Enter the number: ");
            repClockTower.Number = Convert.ToInt32(Console.ReadLine());

            string result = repClockTower.GetPendulumMovement();

            Console.WriteLine(result);

        }
    }
}
