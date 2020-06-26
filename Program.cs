/*
TECHCareers Practice Questions
Author: Andrew Kind
*/

using System;

namespace Practice_Questions
{
    class Program
    {

        static void writeLines()
        {

            Console.WriteLine("Pratice Problems");
            Console.WriteLine("Select 1-4");
            Console.WriteLine("1- int to power of 3");
            Console.WriteLine("2- divide diners bill (double division)");
            Console.WriteLine("3- calculate birth year");
            Console.WriteLine("4- sum of digits");
        }

        static bool validateInput(string userInput)
        {
            int numberOfQuestions = 4;

            //  //https://stackoverflow.com/questions/12644473/c-sharp-check-if-consolekeyinfo-keychar-is-a-number
            // Validate user input.
            // Should be number 1-5
            int number;
            if (Int32.TryParse(userInput, out number))
            {
                // User input is a number
                if (number >= 1 && number <= numberOfQuestions)
                {
                    // valid number
                    return true;
                }

            }
            newLine();

            Console.WriteLine("Invalid input: {0}", userInput);
            return false;

        }



        static void promptMainMenu()
        {
            Console.Clear();
            writeLines();

            // Indicates if the user key is a valid input (key 1-4)
            bool isValid = false;
            string userInput = "";


            while (!isValid)
            {
                userInput = Console.ReadKey().KeyChar.ToString();

                isValid = validateInput(userInput);
            }

            // newLine();
            //  Console.WriteLine("userInput: {0}", userInput);


            switch (userInput)
            {

                case "1":
                    runPractice1();
                    break;
                case "2":

                    break;
                default:

                    break;
            }

        }
        static void Main(string[] args)
        {
            promptMainMenu();
        }

        static void newLine()
        {
            Console.WriteLine("\n");

        }


        static void runPractice1()
        {

            //Write a program that prompts the user for a number (as an int) and outputs the cube of that number (raised to the third power).
            newLine();
            Console.WriteLine("Practice Problem 1: Get a integer and cube it.");

            Console.WriteLine("Please enter a number.");

            int number;
            string userInput;
            while (!Int32.TryParse(userInput = Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. {0} is not a number.", userInput);


            }

            // Cube the int. No need to use Math.Pow because it will require doubles and the user is prompted an integer.
            int cubed = number * number * number;

            Console.WriteLine("{0} cubed is {1}.", number.ToString(), cubed.ToString());

            promptEnter();
            promptMainMenu();

        }

        static void promptEnter()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            newLine();

        }
    }
}
