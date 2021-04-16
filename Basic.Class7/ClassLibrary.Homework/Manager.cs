using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Homework
{
    public class Manager: Employee
    {
        private double Bonus { get; set; }

        //Create a constructor that sets all properties except Bonus

        public Manager(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;

        }

        //Create a method called AddBonus that adds bonus to the Bonus property

        public void AddBonus (int num)
        {
            Bonus = num;
        }

        //Override the method GetSalary to return the Salary + Bonus

        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }



    }




}
