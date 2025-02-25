// Written by Swaroop Sapkota
// 02/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Dog : Animal
    {
        // Constructor
        public Dog(string aName): base(aName)
        {

        }

        // Override MakeSound()
        public override string MakeSound()
        {
            return "Bark";
        }

    }
}
