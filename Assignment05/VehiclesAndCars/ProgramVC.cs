// Written by Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAndCars
{
    public class ProgramVC
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Porsche", "911", 2019);
            Console.WriteLine(vehicle.ToString());

            Car car = new Car("McLaren", "Artura", 2024, 2);
            Console.WriteLine(car.ToString());

            Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Iron 883", 2020, true);
            Console.WriteLine(motorcycle.ToString());
        }
    }
}
