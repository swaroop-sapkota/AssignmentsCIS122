// Written By Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndSpecializations
{
    public class Manager: Employee
    {
        private int numberOfEmployeesManaged = -1;

        // Gets and Sets
        public int NumberOfEmployeesManaged
        {
            get { return this.numberOfEmployeesManaged; }
            set { this.numberOfEmployeesManaged = value; }
        }

        // Constructor
        public Manager(string aName, double aSalary, int aNumberOfEmployeeManaged) : base(aName, aSalary)
        {
            this.NumberOfEmployeesManaged = aNumberOfEmployeeManaged;
        }

        // ToString() method
        public override string ToString()
        {
            return $"Employee: {this.Name}, Salary: ${this.Salary}, No. of employee managed: {this.NumberOfEmployeesManaged}";
        }
    }
}
