// Written by Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesAndCars;

namespace ShapesAndAreas
{
    public class ProgramSA
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 5, "Red");
            Circle circ = new Circle(7, "Blue");

            Console.WriteLine(rect.ToString());
            Console.WriteLine(circ.ToString());
        }
    }
}
