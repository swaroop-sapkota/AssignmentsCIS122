// Written by Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAndAreas
{
    public abstract class Shape
    {
        // class variables

        private string color = "n/a";

        // getter and setter

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }


        // Constructor
        public Shape(string aColor)
        {
            this.Color = aColor;
        }

        // Abstract Method
        public abstract double GetArea();
        
        // ToString Method
        public override string ToString() 
        {
            return $"{this.Color} Shape";
        }

    }
}
