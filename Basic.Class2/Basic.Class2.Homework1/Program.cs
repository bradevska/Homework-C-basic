using System;

namespace Basic.Class2.Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //# Class 2 Homework 📒
            //## Task 1
            //Create new console application “RealCalculator” that takes two numbers from the input
            //and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.
            //* Test Data:
            //*Enter the First number: 10
            //* Enter the Second number: 15
            //* Enter the Operation: +
            //*Expected Output:
            //*The result is: 25

            Console.WriteLine("Enter the first number");
            string inputNumber1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string inputNumber2 = Console.ReadLine();
            Console.WriteLine("Enter the operation");
            string inputOperation = Console.ReadLine();

            string sum = "+";
            string subtract = "-";
            string multiplication = "*";
            string division = "/";


            int num1 = 0;
            bool isValidNumber1 = int.TryParse(inputNumber1, out num1);
            int num2 = 0;
            bool isValidNumber2 = int.TryParse(inputNumber2, out num2);

            int sum1 = num1 + num2;
            int sub = num1 - num2;
            int multi = num1 * num2;
            int div = num1 / num2;


            if(inputOperation == sum)
            {
                Console.WriteLine(sum1);
            }
            if (inputOperation == subtract)
            {
                Console.WriteLine(sub);
            }
            if (inputOperation == multiplication)
            {
                Console.WriteLine(multi);
            }
            if (inputOperation == division)
            {
                Console.WriteLine(div);
            }
            else
            {
                Console.WriteLine("Please enter valid numbers");
            }





            //## Task 2
            //Create new console application “AverageNumber” that takes four numbers as input
            //to calculate and print the average.
            //*Test Data:
            //*Enter the First number: 10
            //* Enter the Second number: 15
            //* Enter the third number: 20
            //* Enter the four number: 30
            //* Expected Output:
            //*The average of 10, 15, 20 and 30 is: 18

            Console.WriteLine("Enter the first number");
            string firstInput= Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string secoundInput = Console.ReadLine();
            Console.WriteLine("Enter the third number");
            string thirdInput = Console.ReadLine();
            Console.WriteLine("Enter the fourth number");
            string fourthInput = Console.ReadLine();

            int number1 = 0;
            bool number1Valid = int.TryParse(firstInput, out number1);
            int number2 = 0;
            bool number2Valid = int.TryParse(secoundInput, out number2);
            int number3 = 0;
            bool number3Valid = int.TryParse(thirdInput, out number3);
            int number4 = 0;
            bool number4Valid = int.TryParse(fourthInput, out number4);

            int average = (number1 + number2 + number3 + number4) / 4;
            if (average % 2 == 0) {
                Console.WriteLine("The average of four inputs numbers is " + average);
            }
            else
            {
                Console.WriteLine("Enter even numbers");
            }


            //## Task 3:
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap
            //the values of the variables so that the first variable has the second value and the second variable the first value.
            //Please find example below:
            //*Test Data:
            //*Input the First Number: 5
            //* Input the Second Number: 8
            //* Expected Output:
            //*After Swapping:
            //*First Number: 8
            //* Second Number: 5

            Console.ReadLine();
        }
    }
}
