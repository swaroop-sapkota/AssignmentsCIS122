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
    public class Triangle
    {
        // Class Variables
        private double baseLength = -1;
        private double height = -1;

        // Gets and Sets
        public double BaseLength
        {
            get { return this.baseLength; }
            set { this.baseLength = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double CalculateArea()
        {
            return 0.5 * this.baseLength * this.height;
        }

        // ToString() Method
        public override string ToString()
        {
            String msg = "";

            msg = $"\nThe Area of Triangle is: {CalculateArea()}"; 

            return msg;
            
        }
    }
}
