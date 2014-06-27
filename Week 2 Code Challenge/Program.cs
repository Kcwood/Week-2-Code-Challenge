using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call for the function Fizzbuzz
            //with the for loop to set up our parameters
            for (int i = 0; i <= 20; i = i + 1)
            {
                FizzBuzz(i);
            }
            //Adds a space between the 
            //function below it
            Console.WriteLine();

            //Calls for the function LetterCounter
            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");

            //Adds a space between the 
            //function below it
            Console.WriteLine();

            //Call for the function TextStats
            TextStats("The tenth doctor is by far my favorite. His sonic screwdriver is the cutest. I also think he is the most dashing.");

            //Keeps the console open
            Console.ReadKey();

        }
         //Setting up a new function
        static void FizzBuzz(int number)
        {
            //Creating the if statement for a 
            //number that is divisible by 5 and 3 
            if (number % 5 == 0 && number % 3 == 0)
            {
                //Prints to the console
                Console.WriteLine("FizzBuzz");
            }
            //Creating an if statement for a 
            //number that is only divisible by 5
            else if (number % 5 == 0)
            {
                //Prints to the console
                Console.WriteLine("Fizz");
            }
            //Creating an if statement for a 
            //number that is only divisible by 3
            else if (number % 3 == 0)
            {
                //Prints to the console
                Console.WriteLine("Buzz");
            }
            //When all the about our false it 
            //will print this to the console
            else
            {
                //Prints to the console
                Console.WriteLine(number);
            }
        }
        //Creating the function LetterCount
        //with the parameters letter and 
        //inString
        static void LetterCounter(char letter, string inString)
        {
            //Setting the counters for lowercase letters
            //and UPPERCASE letters
            int lowerCase = 0;
            int upperCase = 0;
            //Creating a for loop to run through the letters
            //in our string
            for (int i = 0; i < inString.Length; i++)
            {
                //Making the index to find things 
                //in the string
                char neededLetter = inString[i];
                //Getting the counter for lowercase letters
                //to increase when a lowercase letter is found
                if (neededLetter == letter)
                {
                    //Increasing the lowercase 
                    //count by 1 for each lowercase
                    //letter found
                    lowerCase++;
                }
                //Getting the counter for UPPERCASE letters
                //to increase when an UPPERCASE letter is found
                if (char.IsUpper(neededLetter))
                {
                    //Increasing the UPPERCASE
                    //count by 1 for each UPPERCASE
                    //letter found
                    upperCase++;
                }
                    
            }
            //Getting the total number of lowercase
            //and UPPERCASE letters
            int totalNumber = lowerCase + upperCase;
            //Things printed to the console
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + lowerCase);
            Console.WriteLine("Number of UPPERCASE " + letter + "'s found: " + upperCase);
            Console.WriteLine("Total number of " + letter + "'s found: " + totalNumber);
            Console.WriteLine();
            

        }
        //creating the function TextStats with
        //the string parameter "input"
        static void TextStats(string input)
        {
            //Declaring function variables
            List<string> inputList = input.Split(' ').ToList();
            //Creating our variable for vowels
            int vowelNum = 0;
            //Creating our variable for consonants
            int consonantNum = 0;
            //Creating our variable for
            //special characters
            int specialChar = 0;

            //Setting up the counts for vowels, consonants 
            //and special characters
            for (int i = 0; i < input.Length; i = i + 1)
            {
                char letter = input[i];
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'y')
                {
                    vowelNum++;
                }
                if (letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u' && letter != 'y' && letter != ' ' && letter != '.')
                {
                    consonantNum++;
                }
                if (letter == ' ' || letter == '.')
                {
                    specialChar++;
                }
            }
            //Variable for longest word
            var longest = "";
            //Variable for shortest word
            var shortest = "  ";
            //Creating the loop to go over all 
            //the words in my sentences
            foreach (string word in inputList)
            {
                //If word is longer that the
                //longest length
                if (word.Length > longest.Length)
                {
                        //Then that is the longest word
                        longest = word;
                }
                //If word is shorter than the shortest word
                if (word.Length < shortest.Length)
                {
                        //Then that is the shortest word
                        shortest = word;
                }
            }

            //Write to the console
            Console.WriteLine("The total number of characters: " + input.Length);
            Console.WriteLine("The total number of words: " + inputList.Count);
            Console.WriteLine("The number of vowels is " + vowelNum);
            Console.WriteLine("The number of consonants is " + consonantNum);
            Console.WriteLine("The number of special characters is " + specialChar);
            Console.WriteLine("Longest word: " + longest);
            Console.WriteLine("Shortest word: " + shortest);
        }
    }
}
