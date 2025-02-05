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
    public class RepClockTower
    {
        // Class variable
        private int number = -1;

        // Getter and Setter
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        // Method to determine if the number is even or odd.
        
        public string GetPendulumMovement()
        {
            if((this.Number % 2) == 0)
            {
                return "Tick";
            }
            else
            {
                return "Tock";
            }
        }

    }
}
