// Written by Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    public class Rectangle: Shape
    {
        private double width = -11.11;
        private double height = -11.11;

        // Get and set
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        // Constructor
        public Rectangle(double aWidth, double aHeight, string color): base(color)
        {
            this.Width = aWidth;
            this.Height = aHeight;
        }

        // Methods

        public override double GetArea()
        {
            return (this.Width * this.Height);
        }
        // ToString Method

        public override string ToString()
        {
            return $"Width: {this.Width} Height: {this.Height} \nArea of Rectange: {GetArea()}";
        }
    }
}
