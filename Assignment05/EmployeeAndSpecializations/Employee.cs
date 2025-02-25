// Written By Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndSpecializations
{
    public class Employee
    {
        // class variables

        private string name = "n/a";
        private double salary = -9999.99;

        // getter and setter

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        // Constructor
        public Employee(string aName, double aSalary)
        {
            this.Name = aName;
            this.Salary = aSalary;
        }

        // ToString Method
        public override string ToString()
        {
            return $"Employee: {this.Name}, Salary: ${this.Salary}";
        }

    }
}
