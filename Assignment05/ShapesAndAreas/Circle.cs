// Written by Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    public class Circle : Shape
    {
        private double radius = -11.11;

        // Gets and Sets
        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        // Constructor
        public Circle(double aRadius, string color): base(color)
        {
            this.Radius = aRadius;
        }

        // Methods

        public override double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
        // ToString() method
        public override string ToString()
        {
            return $"Radius: {this.Radius}  \nArea of Circle: {GetArea()}";
        }
    }
}
