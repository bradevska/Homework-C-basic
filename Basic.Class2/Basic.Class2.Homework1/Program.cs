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


            double num1 = 0;
            bool isValidNumber1 = double.TryParse(inputNumber1, out num1);
            double num2 = 0;
            bool isValidNumber2 = double.TryParse(inputNumber2, out num2);

            double sum1 = num1 + num2;
            double sub = num1 - num2;
            double multi = num1 * num2;
            double div = num1 / num2;


            if((isValidNumber1 )|| (isValidNumber2 )) 
            {
                Console.WriteLine("Valid Parsing. " + " The first parsing number is " + num1 + " The secound parsing number is " + num2);
            }else
            {
                Console.WriteLine("Not valid parsing");
            }



            if(inputOperation == sum)
            {
                Console.WriteLine("The result of sum is " + sum1);

            }
            else if (inputOperation == subtract)
            {
                Console.WriteLine("The result of subtract is " + sub);
            }
            else if (inputOperation == multiplication)
            {
                Console.WriteLine("The result of multiplication is " + multi);
            }
            else if (inputOperation == division)
            {
                Console.WriteLine("The result of division is " + div);
            }
            else
            {
                Console.WriteLine("Please enter valid operation");
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

            double number1 = 0;
            bool number1Valid = double.TryParse(firstInput, out number1);
            double number2 = 0;
            bool number2Valid = double.TryParse(secoundInput, out number2);
            double number3 = 0;
            bool number3Valid = double.TryParse(thirdInput, out number3);
            double number4 = 0;
            bool number4Valid = double.TryParse(fourthInput, out number4);


            if ((number1Valid) || (number2Valid) || (number3Valid) || (number4Valid))
            {
                Console.WriteLine("Valid Parsing. " + " " + number1 + " " + number2 + " " + number3 + " " + number4);
            }
            else
            {
                Console.WriteLine("Not valid parsing");

            }

                double average = (number1 + number2 + number3 + number4) / 4;

            Console.WriteLine("The averige of inputs is " + average);


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

            Console.WriteLine("Enter the first number");
            string firstInputNumber = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string secoundInputNumber = Console.ReadLine();
            
            int input1 = int.Parse(firstInputNumber);
            int input2 = int.Parse(secoundInputNumber);

            int temorary = input1;
            input1 = input2;
            input2 = temorary;

            Console.WriteLine("The value of first number is: "  + input1);
            Console.WriteLine("The value of second number is: "  + input2);
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
