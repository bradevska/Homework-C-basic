using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Homework
{
    public class SalesPerson : Employee
    {
        public SalesPerson()
        {

        }
        public SalesPerson(string firstName, string lastName, Role role)
        {
           
            //The salary is by default 500 and role is default Sales
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Sales;
            Salary = 500;
           
        }
        //SuccessSaleRevenue double, private
        private double SuccessSaleRevenue { get; set; }

        

        //Create a method called AddSuccessRevenue that will get a number and set the SuccessSaleRevenue to that value

        public void AddSuccessRevenue (double num)
        {
            SuccessSaleRevenue = num;       
        }

        //Override the GetSalary method to return the value of the salary plus
        //bonus that is calculated by the SuccessSaleRevenue. ▹
        //If less or equal to 2000 then add 500 bonus
        //If larger than 2000 but less or equal than 5000 then add 1000 bonus▹
        //If larger than 5000 add 1500 bonus

        public override double GetSalary()
        {

            if (SuccessSaleRevenue <= 2000) {
                Salary += Salary + 500;
                return Salary;
            } else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                Salary += Salary + 1000;
                return Salary;
            } else
            {
                Salary += Salary + 1500;
                return Salary;
            }

        }



    }
}
