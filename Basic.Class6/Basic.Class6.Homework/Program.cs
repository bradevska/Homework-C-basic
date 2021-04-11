using Basic.Class6.Homework.Clases;
using System;

namespace Basic.Class6.Homework
{
    class Program
    {
        //Make a method RaceCars() that will get two Car objects that will determine
        //which car will win and print the result in the console.
        //Make 4 car objects and 4 driver objects.
        // Ask the user to select a two cars and two drivers for the cars.Add the drivers to the cars and call the RaceCars() methods

       static void RaceCars(Carr car1, Carr car2)
        {

            int car1Speed = car1.CalculateSpeed();
            int car2Speed = car2.CalculateSpeed();
            if(car1Speed > car2Speed)
            {
                Console.WriteLine($"{car1.Model} is faster");
            }
            else
            {
                Console.WriteLine($"{car2.Model}  is faster");
            }
                
        }
        static void Main(string[] args)
        {

            Carr[] carArr = new Carr[]
            {
                new Carr("Opel" , 100 , "Leo"),
                new Carr("Toyota" , 150 , "Leon"),
                new Carr("Mercedes" , 180 , "Filip"),
                new Carr("Seat" , 120 , "Petar"),
                
            };

            Driver[] driverArr = new Driver[]
            {
                new Driver("Leo" , 4 ),
                new Driver("Leon" , 3 ),
                new Driver("Filip" , 2 ),
                new Driver("Petar" ,5 ),

            };



            Console.WriteLine($" Enter first choice: {carArr[0]} {carArr[1]} {carArr[2]} {carArr[3]} ");
            string firstCarInput = Console.ReadLine();
            Console.WriteLine(" Enter second choice: ");
            string secondcarInput = Console.ReadLine();
          

            





        }
    }
}
