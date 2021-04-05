using System;

namespace Basic.Class3.BonusHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 1
            //Write a program that will print out all numbers from the range 1-N
            //(N is input from keyboard, N>2) that divide with 3

            //Console.WriteLine("Please enter  number bigger than 2");
            //int inputNumber = int.Parse(Console.ReadLine());


            //    for (int i=1; i < inputNumber; i++)
            //    {
            //        if(i % 3 == 0)
            //        {
            //            Console.WriteLine(i);
            //        } else
            //        {
            //        Console.WriteLine("The number " + i + " is not devide with 3");
            //        }   
            //    }

            //Console.ReadLine();



            //Task 2
            //Write a program that will print out all numbers in the range 1-N
            //(N is input from keyboard, N>5) that divide 2 and 3.

            //Console.WriteLine("Please enter  number bigger than 5");
            //int inputNumber1 = int.Parse(Console.ReadLine());

            //for (int i = 1; i < inputNumber1; i++)
            //{
            //    if (i % 2 == 0 || i % 3== 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number " + i + " is not devide with 2 and 3");
            //    }
            //}

            //Console.ReadLine();

            //Task 3
            //Write a program, which will be calculating the product of the digits of an input number.

            //Console.WriteLine("Enter any number...");
            //int num = int.Parse(Console.ReadLine());

            //int proizvod = 1;

            //while (num != 0)
            //{
            //    proizvod = proizvod * (num % 10);

            //    // Remove the last digit from n
            //    num = num / 10;
            //}

            //Console.WriteLine("Product of digits = " + proizvod);

            //Console.ReadLine();




            //Task 4
            //Write a program that will find out the sum of all even numbers in the range 1-N
            //(N is input from keyboard).

            //Console.WriteLine("Please enter number");
            //int input2 = int.Parse(Console.ReadLine());

            //int sum = 0;
            // for(int i = 1; i < input2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }

            //}
            //Console.WriteLine(sum);

            //Console.ReadLine();


            //Task 5
            //Write a program that will find out the sum of all odd numbers in the range 1-N
            //(N is input from keyboard).

            //Console.WriteLine("Please enter number");
            //int input3 = int.Parse(Console.ReadLine());

            //int sum1 = 0;
            //for (int i = 1; i < input3; i++)
            //{
            //    if (i  % 2 != 0)
            //    {
            //        sum1 += i;
            //    }

            //}
            //Console.WriteLine(sum1);

            //Console.ReadLine();




            //Task 6
            //Write a program that will find out the sum of all numbers that divide 5
            //in the range 1-N (N is input from keyboard).

            //Console.WriteLine("Please enter number");
            //int input4 = int.Parse(Console.ReadLine());

            //int sum2 = 0;
            //for(int i = 1; i <= input4; i++) // <= pomalo i ednakvo(ova ako i input brojot vleguva vo presmetkata)
            //{
            //    if(i % 5 == 0)
            //    {
            //        sum2 += i;
            //    }
            //}

            //Console.WriteLine("The sum of all number that divide 5 is  " + sum2);
            //Console.ReadLine();



            //Task 7
            //Write a program that will reverse the array {“a”,”b”,”c”,”d”} so that the output is {“d”,“c”,“b”,“a”}.
            //-Do NOT use reverse array method:) 

            //string[] arr = new string[4] { "a", "b", "c", "d" };

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Console.ReadLine();


            //Task 8
            //Write a program that will read two arrays from console input.
            //Then the program has to make a comparison of the arrays and determine whether they are equal or not.
            //{ 1, 2, 3, 4 } == { 1, 2, 3, 4 }
            //{ 1, 2, 3, 4 } != { 2, 1, 3, 4 }




            //Task 9
            //Write a program that will find all numbers in between 1 and 1000,
            //that divide the sum composed of their digits.


            //Task 10
            //Write a program that will find out all numbers in the range [1 : 1000]
            //that divide the product composed of their digits.


            //Task 11:
            //Write a program that will print out all two-digit numbers,
            //which have the first digit greater than the second digit.




            //Task 12:
            //Write a short program that prints each number from 1 to 100 on a new line.
            //For each number that is divided by 3 print “Fizz” instead of the number.
            //For each number that is divided by 5 print “Buzz” instead of the number.
            //For each number that is divided by 3 and 5  print “FizzBuzz” instead of the number.

            int[] array = new int[100];

            foreach(int numbers in array)
            {
                
                if(numbers % 3 == 0)
                {
                    Console.WriteLine("Number is divided by 3 .......Fizz");
                }
                if (numbers % 5 == 0)
                {
                    Console.WriteLine("Number is divided by 5........Buzz");
                }
                if (numbers % 3 == 0 && numbers % 5 ==0)
                {
                    Console.WriteLine("Number is divided by 3 and 5.......FizzBuzz");
                }


            }
        }
    }
}
