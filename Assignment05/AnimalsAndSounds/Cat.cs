// Written by Swaroop Sapkota
// 02/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Cat: Animal
    {
        // Constructor
        public Cat(string aName) : base(aName)
        {

        }
        
        // Override MakeSound()
        public override string MakeSound()
        {
            return "Meow";
        }

    }
}
