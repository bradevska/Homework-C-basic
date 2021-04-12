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

       
        static void Main(string[] args)
        {

            Car[] carArr = new Car[]
            {
                new Car("Opel" , 100 ),
                new Car("Toyota" , 150 ),
                new Car("Mercedes" , 180 ),
                new Car("Seat" , 120 ),
                
            };

            Driver[] driverArr = new Driver[]
            {
                new Driver("Leo" , 4 ),
                new Driver("Leon" , 3 ),
                new Driver("Filip" , 2 ),
                new Driver("Petar" ,5 ),

            };
            Car car1 = new Car();
            Car car2 = new Car();
            Driver firstDriver = new Driver();
            Driver secondDriver = new Driver();

            Console.WriteLine($"Please enter car No.1 with driver " +
                $"\n {carArr[0].Model}, driver is  {driverArr[0].Name} " +
                $"\n {carArr[1].Model}, driver is  {driverArr[1].Name}" +
                $"\n {carArr[2].Model}, driver is  {driverArr[2].Name}" +
                $"\n {carArr[3].Model}, driver is  {driverArr[3].Name}");
            string userInputOne = Console.ReadLine();
            Console.WriteLine($"Please enter car No.2 with driver " +
                $"\n {carArr[0].Model},driver is{driverArr[0].Name}" +
                $"\n {carArr[1].Model},driver is {driverArr[1].Name}" +
                $"\n {carArr[2].Model},driver is {driverArr[2].Name}" +
                $"\n {carArr[3].Model},driver is {driverArr[3].Name}");
            string userInputTwo = Console.ReadLine();
            
            RaceCars(car1, car2);
        }
        
        static void RaceCars(Car car1, Car car2)
        {

            int car1Speed = car1.CalculateSpeed();
            int car2Speed = car2.CalculateSpeed();
            if (car1Speed > car2Speed)
            {
                Console.WriteLine($"From two selected cars {car1.Model} is faster");
            }
            else 
            {
                Console.WriteLine($"From two selected cars {car2.Model}  is faster");
            }

            Console.ReadLine();
        }

       
    }
}
