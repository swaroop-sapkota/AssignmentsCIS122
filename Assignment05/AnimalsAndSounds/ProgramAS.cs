// Written by Swaroop Sapkota
// 02/25/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class ProgramAS
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Unknown");
            Dog dog = new Dog("Nova");
            Cat cat = new Cat("Oreo");

            Console.WriteLine(animal);
            Console.WriteLine(dog);
            Console.WriteLine(cat);

        }
    }
}
