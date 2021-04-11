using System;
using System.Collections.Generic;
using System.Text;

namespace Basic.Class6.Homework.Clases
{
    public class Carr
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }

        public Carr( string model, int speed, string driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }


        // Make a method of the Car class called :
        // CalculateSpeed() that takes a driver object and calculates the skill
        // multiplied by the speed of the car and return it as a result.

       public int CalculateSpeed(Driver driver)//zasto kako parametar Driver driver??? Razbiram deka e od clasata Deriver ali zasto pak so malo driver
        {
           
            return Speed * driver.Skill;
        }





    }
}
