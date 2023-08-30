using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unisys.EmployeeManagement;

namespace CSharpConcept
{
    internal class Demo6EmployeeTest
    {
        public static void Main6(String[] args)
        {
            Employee emp1 = new Employee(101, "saul", 9000, "B", "Unisys");
            Employee emp2 = new Employee(102, "kim", 6000, "A", "Unisys");
            Employee emp3 = new Employee(103, "peter", 4000, "C", "Unisys");

            emp1.displayEmployeeDetails();
            emp2.displayEmployeeDetails();
            
            emp3.Id = -103;
            emp3.displayEmployeeDetails();



        }
    }
}
