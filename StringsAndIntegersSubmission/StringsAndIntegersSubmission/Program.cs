using System;
using System.Collections.Generic;

namespace StringsAndIntegersSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of integers to be divided
            List<int> intList = new List<int>();
            intList.Add(8);
            intList.Add(10);
            intList.Add(4);
            intList.Add(12);
            intList.Add(7);
            intList.Add(2);
            // Message to user with instructions.
            Console.WriteLine("Pick a number.This number will be used to divide each number in the list.");
            // This block will try each command if unable the catch block will display a user-friendly message.
            try
            {
                // This line stores user input as a variable
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                // This line takes each element of the list
                foreach (int i in intList)
                {
                    // Message prints and includes the list item and user input variable
                    Console.WriteLine("{0} / {1} = {2}", i, userInput, i / userInput);
                }
            }
            // If used inputs zero ...
            catch (DivideByZeroException)
            {
                // Then this user friendly message displays.
                Console.WriteLine("Don't divide by zero.");
            }
            // If user inputs anything other than a number...
            catch (FormatException)
            {
                // Then this user friendly message displays.
                Console.WriteLine("Give me a whole number!");
            }
            // This block will run after previous blocks, regardless of their outcome.
            finally
            {
                // This message displays at the end of the program run.
                Console.WriteLine("Program complete!");
            }
            // This line keeps the information displayed for user.
            Console.ReadLine();
        }
    }
}
