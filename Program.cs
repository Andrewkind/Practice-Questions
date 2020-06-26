/*
TECHCareers Practice Questions
Author: Andrew Kind
*/

using System;

namespace Practice_Questions
{
    class Program
    {


        // Write the Main Menu Lines
        static void writeLines()
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Pratice Problems \n");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Select 1-4");
            Console.WriteLine("1- int to power of 3");
            Console.WriteLine("2- divide diners bill (double division)");
            Console.WriteLine("3- calculate birth year");
            Console.WriteLine("4- sum of digits");
        }

        // Validate user input from main menu
        // It should be a key from numbers 1-4
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
            Console.WriteLine("\n");

            Console.WriteLine("Invalid input: {0}", userInput);
            return false;

        }



        //Perform tasks to prompt the main menu
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


            Console.Clear();
            switch (userInput)
            {

                case "1":
                    runPractice1();
                    break;
                case "2":
                    runPractice2();
                    break;
                default:

                    break;
            }

        }
        static void Main(string[] args)
        {
            promptMainMenu();
        }

        // Helper method for new line



        // Practice Problem 1

        //Write a program that prompts the user for a number (as an int) and outputs the cube of that number (raised to the third power).

        static void runPractice1()
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Practice Problem 1: Get an integer and cube it. ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\nPlease enter a number.");

            int number;
            string userInput;
            while (!Int32.TryParse(userInput = Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. {0} is not a number.", userInput);


            }

            // Cube the int. No need to use Math.Pow because it will require doubles and the user is prompted an integer.
            int cubed = number * number * number;

            Console.WriteLine("{0} cubed is {1}.", number.ToString(), cubed.ToString());

            promptAnyKey();
            promptMainMenu();

        }

        //Write a program that will take in a total dollar value (as a double) and a number of diners (as an int) and calculate the amount of the bill that each diner should pay (equal split).
        static void runPractice2()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Practice Problem 2: Split the bill. Get a double and divide.");
            Console.BackgroundColor = ConsoleColor.Black;


            // Get the user input for the bill amount.
            // Must be a double value
            Console.WriteLine("\nWhat was the total on the bill?");

            double cost;
            string userInput;
            while (!Double.TryParse(userInput = Console.ReadLine(), out cost))
            {
                Console.WriteLine("Invalid input. {0} is not a double.", userInput);

            }

            // Get the number of guests.
            // Guest number is an int
            Console.WriteLine("How many guests to split by?");

            int guests;
            while (!Int32.TryParse(userInput = Console.ReadLine(), out guests))
            {
                Console.WriteLine("Invalid input. {0} is not a int.", userInput);

            }
            ////
            ////

            // Calculate cost per guest. 
            double costPerGuest = cost / guests;

            // Round answer
            costPerGuest = Math.Round(costPerGuest, 2);


            //https://stackoverflow.com/questions/23361554/number-to-string-always-2-decimal-place
            Console.WriteLine("With the total value being {0}$ and {1} guests, the split bill would be {2}$ per guest.", cost.ToString("0.00"), guests.ToString(), costPerGuest.ToString("0.00"));

            promptAnyKey();
            promptMainMenu();
        }

        static void promptAnyKey()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("\n");

        }
    }
}
