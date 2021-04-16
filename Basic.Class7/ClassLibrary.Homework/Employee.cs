using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Homework
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee ()
        {

        }


        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName},{LastName},{Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }

}
