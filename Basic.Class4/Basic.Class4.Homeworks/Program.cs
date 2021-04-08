using System;

namespace Basic.Class4.Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            // * Create a new method called FunWithStrings that will have one input parameter (string) and it will have no return
            // *In that method you should display in console the following tasks for the string:
            //*print the reverse string
            //* print total number of vowels
            //* check if string is palindrome
            //* print the largest word
            //* print the smallest word
            //* print the count of words
            //*print the most used character(not space obviously)
            //*Ask the user to enter a string and call the method with that string.


            Console.WriteLine("Enter some text");
            string input = Console.ReadLine().ToLower();
            FunWithStrings(input);

            //*print the reverse string
            string revers = input;
            string reversText = String.Empty;
            char[] charArray = revers.ToCharArray();
            for(int i = charArray.Length - 1; i > -1; i--)
            {
                reversText += charArray[i];
            }

            Console.WriteLine(reversText);

            //* print total number of vowels

            int total = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    total++;
                }
            }

            Console.WriteLine(total);

            //* check if string is palindrome

            //* print the largest word
            //* print the smallest word

            string string1 = input;
            string word = "",small = "", large = "";
            string[] words = new string[100];
            int length = 0;

            string1 = string1 + " ";
            for (int i = 0; i < string1.Length; i++)
            {
                //Split the string into words  
                if (string1[i] != ' ')
                {
                    word = word + string1[i];
                }
                else
                {
                    //Add word to array words  
                    words[length] = word;
                    //Increment length  
                    length++;
                    //Make word an empty string  
                    word = "";
                }
            }

            //Initialize small and large with first word in the string  
            small = large = words[0];

            //Determine smallest and largest word in the string  
            for (int k = 0; k < length; k++)
            {

                //If length of small is greater than any word present in the string  
                //Store value of word into small  
                if (small.Length > words[k].Length)
                    small = words[k];

                //If length of large is less than any word present in the string  
                //Store value of word into large  
                if (large.Length < words[k].Length)
                    large = words[k];
            }
            Console.WriteLine("Smallest word: " + small);
            Console.WriteLine("Largest word: " + large);

            //* print the count of words
            int a = 0;
            int myWord = 1;
            string str = input;
            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    myWord++;
                }
                a++;
            }
            Console.WriteLine(myWord);


            //*print the most used character(not space obviously)






            //## Task 2
            //*Create a new method that will remove extra space characters
            //*Call the method with the following text:
            //The & nbsp; &nbsp; &nbsp; best & nbsp; Lorem & nbsp; Ipsum & nbsp;
            //&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Generator in all the&nbsp; sea!
            //& nbsp; &nbsp; Heave this & nbsp; scurvy copyfiller fer yar&nbsp; &nbsp; &nbsp;
            //&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; next & nbsp; &nbsp; adventure & nbsp; and cajol yar
            //clients&nbsp; &nbsp; into walking  the plank with ev'ry layout!&nbsp;&nbsp;&nbsp;
            //Configure&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  above, then get yer pirate ipsum...own
            //the high seas,&nbsp;&nbsp;&nbsp; argh!




            Console.ReadLine();
        }

        static void FunWithStrings (string text)
        {
            Console.WriteLine(text);       
        }


        
    }
}
