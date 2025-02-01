// Written by Swaroop Sapkota
// 01/29/2025
// The Triangle Farmer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFarmer
{
    public class TheTriangleFarmer
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Console.Write("Enter the base of the triangle: ");
            triangle.BaseLength = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter the height of the triangle: ");
            triangle.Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(triangle.ToString());

        }
    }
}
