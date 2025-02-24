// Written by Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAndCars
{
    public class Vehicle
    {
        // class variables

        private string make = "n/a";
        private string model = "n/a";
        private int year = -1;

        // getter and setter

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        // Constructor
        public Vehicle(string aMake, string aModel, int aYear)
        {
            this.Make = aMake;
            this.Model = aModel;
            this.Year = aYear;
        }
        
        // ToString Method
        public override string ToString() 
        {
            return $"{this.Year} {this.Make} {this.Model}";
        }

    }
}
