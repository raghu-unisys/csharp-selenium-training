using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.EmployeeManagement
{
    public class Employee
    {
        private int id;
        public string name;
        public double salary;
        public string performance;
        public string companyName;

        // creating a property
        public int Id
        { 
            get { return id; } 
            set { if (id > 100) id = value; else Console.WriteLine("Invalid ID"); }
        }

        public Employee(int id, string name, double salary, string performance, string companyName)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.performance = performance;
            this.companyName = companyName;
        }

        public void displayEmployeeDetails()
        {
            Console.WriteLine("Employeed ID : " + id);
            Console.WriteLine("Employee name : " + name);
            Console.WriteLine("Employee salary: " + salary);
            Console.WriteLine("Employee performace: " + performance);
            Console.WriteLine("Company name : " + companyName);
            Console.WriteLine("--------------");
        }


    }
}
