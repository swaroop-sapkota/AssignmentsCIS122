// Written by Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAndCars
{
    public class Car : Vehicle
    {
        private int numberOfDoors = -1;

        // Gets and Sets
        public int NumberOfDoors
        {
            get { return this.numberOfDoors; }
            set { this.numberOfDoors = value; }
        }

        // Constructor
        public Car(string aMake, string aModel, int aYear, int aNumberOfDoors): base(aMake, aModel, aYear)
        {
            this.NumberOfDoors = aNumberOfDoors;
        }

        // ToString() method
        public override string ToString()
        {
            return $"{this.Year} {this.Make} {this.Model} with {this.NumberOfDoors} doors";
        }
    }
}
