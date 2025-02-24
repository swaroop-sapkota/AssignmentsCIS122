// Written by Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAndCars
{
    public class Motorcycle: Vehicle
    {
        private bool hasSidecar = false;

        // Get and set
        public bool HasSidecar
        {
            get { return this.hasSidecar; }
            set { this.hasSidecar = value; }
        }

        // Constructor
        public Motorcycle(string aMake, string aModel, int aYear, bool aHasSidecar) : base(aMake, aModel, aYear)
        {
            this.HasSidecar = aHasSidecar;
        }

        // ToString Method

        public override string ToString()
        {
            return $"{this.Year} {this.Make} {this.Model} (Has Sidecar: {this.HasSidecar})";
        }
    }
}
