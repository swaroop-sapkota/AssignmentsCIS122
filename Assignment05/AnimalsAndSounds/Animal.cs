// Written by Swaroop Sapkota
// 02/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Animal
    {
        // class variables

        private string name = "n/a";

        // getter and setter

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        // Constructor
        public Animal(string aName)
        {
            this.Name = aName;
        }
        
        // Virtual method MakeSound()
        public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }

        // ToString() Method
        public override string ToString() 
        {
            return $"Animal: {this.Name}, Sound: {MakeSound()}";
        }

    }
}
