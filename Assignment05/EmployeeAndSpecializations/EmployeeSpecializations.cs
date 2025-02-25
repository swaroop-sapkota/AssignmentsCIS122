// Written By Swaroop Sapkota
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndSpecializations
{
    public class EmployeeSpecializations
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("YUIOP", 85699.99);
            Console.WriteLine(employee.ToString());

            Manager manager= new Manager("GHJKL", 123999.99, 145);
            Console.WriteLine(manager.ToString());

            Engineer engineer = new Engineer("ASDFG", 111119.55, "Aerospace");
            Console.WriteLine(engineer.ToString());
        }
    }
}
