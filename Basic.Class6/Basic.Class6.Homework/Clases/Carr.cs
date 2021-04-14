using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Class6.Homework.Clases
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public Driver Driver = new Driver();


        public Car()
        {

        }



        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;



        }

        public int CalculateSpeed(Driver driver)
        {

            return Speed * driver.Skill;
        }

        

        // Make a method of the Car class called :
        // CalculateSpeed() that takes a driver object and calculates the skill
        // multiplied by the speed of the car and return it as a result.







    }
}
