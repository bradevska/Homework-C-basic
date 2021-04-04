using System;

namespace Basic.Class3.Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a console application called SumOfEven.
            //Inside it create an array of 6 integers.Get numbers from the input,
            //find and print the sum of the even numbers from the array:
            //*Test Data:
            //*Enter integer no.1:
            //*4
            //* Enter integer no.1:
            //*3
            //* Enter integer no.1:
            //*7
            //* Enter integer no.1:
            //*3
            //* Enter integer no.1:
            //*2
            //* Enter integer no.1:
            //*8
            //* Expected Output:
            //*The result is: 14


            //int[] array = new int[6];

            //int sum = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("Enter input number");
            //    int input = int.Parse(Console.ReadLine());
            //    array[i] = input;

            //    if (input % 2 == 0)
            //    {
            //        sum += input;
            //        Console.WriteLine("The sum of even number in array is: " + sum);
            //    } else
            //    {
            //        Console.WriteLine("Odd number");
            //    }

            //}

            //Console.ReadLine();



            //## Task 2
            //* Make a new console application called StudentGroup
            //* Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names. 
            //* Get a number from the console between 1 and 2 and print the students from that group in the console.
            //* Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
            //* Test Data:
            //*Enter student group: (there are 1 and 2 )
            //    *1
            //* Expected Output:
            //  *The Students in G1 are: 
            //  *Zdravko
            //  * Petko
            //  * Stanko
            //  * Branko
            //  * Trajko

            ///////////////// SOLUTION 1

            //string[] studentsG1 = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            //string[] studentsG2 = new string[5] { "Goran", "Filip", "Oleg", "Danilo", "Luka" };


            //Console.WriteLine("Enter nuber 1 or 2");
            //int inputNumber = int.Parse(Console.ReadLine());


            //if(inputNumber == 1)
            //{
            //    Console.WriteLine("The students in G1 group are:" + "\n" + String.Join("\n", studentsG1)); 
            //}
            //else if (inputNumber == 2) {

            //    Console.WriteLine("The students in G2 group are:" +  "\n" + String.Join("\n",studentsG2));
            //}
            //else
            //{
            //    Console.WriteLine("Please enter valid number 1 or 2");
            //}

            //Console.ReadLine();

            /////////////////// SOLUTION 2

            //string[] studentsG1 = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            //string[] studentsG2 = new string[5] { "Goran", "Filip", "Oleg", "Danilo", "Luka" };

            //Console.WriteLine("Enter nuber 1 or 2");
            //int inputNumber = int.Parse(Console.ReadLine());

            //switch (inputNumber)
            //{
            //    case 1:
            //        for (int i = 0; i < studentsG1.Length; i++)
            //        {
            //            Console.WriteLine(studentsG1[i]);
            //        };
            //        break;
            //    case 2:
            //        for (int i = 0; i < studentsG2.Length; i++)
            //        {
            //            Console.WriteLine(studentsG2[i]);

            //        };
            //        break;
            //    default:
            //        Console.WriteLine("Please enter valid number 1 or 2");
            //        break;

            //}

            //Console.ReadLine();


            ////////////////// SOLUTION 3
            ///
            string[][] arrayOfStudentsArrays = new string[5][];
            arrayOfStudentsArrays[0] = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            arrayOfStudentsArrays[1] = new string[] { "Goran", "Filip", "Oleg", "Danilo", "Luka" };

            Console.WriteLine("Enter nuber 1 or 2");
            int inputNumber = int.Parse(Console.ReadLine());

            foreach (string[] stringArray  in arrayOfStudentsArrays)
            {
                foreach(string names in stringArray)
                    if (inputNumber == 1)
                    { 
                     Console.WriteLine(names[0]);
                    }
                    else if (inputNumber == 2)
                    {
                        Console.WriteLine(names[1]);
                    }
                    
            }


            Console.ReadLine();





        }
    }
}
