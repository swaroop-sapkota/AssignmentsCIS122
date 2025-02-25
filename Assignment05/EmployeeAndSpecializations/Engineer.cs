// Written By Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndSpecializations
{
    public class Engineer: Employee
    {
        private string specialization = "n/a";

        // Get and set
        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }

        // Constructor
        public Engineer(string aName, double aSalary, string aSpecialization) : base(aName, aSalary)
        {
            this.Specialization = aSpecialization;
        }

        // ToString Method

        public override string ToString()
        {
            return $"Employee: {this.Name}, Salary: ${this.Salary}, Specialization: {this.Specialization}";
        }
    }
}
