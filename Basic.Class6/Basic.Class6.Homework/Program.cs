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

            Car car1 = new Car("Opel",100);
            Car car2 = new Car("Toyota",150);
            Car car3 = new Car("Mercedes", 180);
            Car car4 = new Car("Seat", 120);

            Driver driver1 = new Driver("Leo",4);
            Driver driver2 = new Driver("Leon",3);
            Driver driver3 = new Driver("Filip", 2);
            Driver driver4 = new Driver("Peatr", 5);

            Car[] carArr = new Car[] { car1, car2, car3, car4 };
            Driver[] driverArr = new Driver[] { driver1, driver2, driver3, driver4 };
            
            

            Console.WriteLine($"Enter first car: \n{car1.Model} \n{car2.Model} \n{car3.Model} \n{car4.Model}");
            int firstCar = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter driver for the first car: \n{driver1.Name} \n{driver2.Name} \n{driver3.Name} \n{driver4.Name}");
            int firstDriver = int.Parse(Console.ReadLine());

            carArr[firstCar - 1].Driver = driverArr[firstDriver - 1];

            Console.WriteLine($"Enter second car: \n{car1.Model} \n{car2.Model} \n{car3.Model} \n{car4.Model}");
            int secondCar = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter driver for the second car: \n{driver1.Name} \n{driver2.Name} \n{driver3.Name} \n{driver4.Name}");
            int secondDriver = int.Parse(Console.ReadLine());

            carArr[secondCar - 1].Driver = driverArr[secondDriver - 1];

            RaceCars(carArr[firstCar - 1], carArr[secondCar - 1]);

            Console.ReadLine();

        }
        
        static void RaceCars(Car car1, Car car2)
        {

            int car1Speed = car1.CalculateSpeed(car1.Driver);
            int car2Speed = car2.CalculateSpeed(car2.Driver);
            if (car1Speed > car2Speed)
            {
                Console.WriteLine($"From two selected cars with drivers {car1.Model} is faster");
            }
            else 
            {
                Console.WriteLine($"From two selected cars with drivers {car2.Model}  is faster");
            }

            Console.ReadLine();
        }

       
    }
}
