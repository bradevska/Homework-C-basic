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
            if(car1.Speed > car2.Speed)
            {
                Console.WriteLine("car1 is faster");
            }
            else
            {
                Console.WriteLine("car2 is faster");
            }
                
        }
        static void Main(string[] args)
        {
            Carr car1 = new Carr();
            car1.Model = "Citroen";
            car1.Speed = 120;
            car1.Driver = "Jon";

            Carr car2 = new Carr();
            car2.Model = "Opel";
            car2.Speed = 100;
            car2.Driver = "Leo";

            Carr car3 = new Carr();
            car3.Model = "Toyota";
            car3.Speed = 125;
            car3.Driver = "Petar";

            Carr car4 = new Carr();
            car4.Model = "Mercedes";
            car4.Speed = 180;
            car4.Driver = "Filip";

            Console.WriteLine("Enter first car");
            string firstCarInput = Console.ReadLine();
            Console.WriteLine("Enter second car");
            string secondcarInput = Console.ReadLine();

            





        }
    }
}
