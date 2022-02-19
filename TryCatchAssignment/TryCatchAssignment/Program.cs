using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Asking for user input.
                Console.WriteLine("Please enter your current age: ");
                // Converts user input and stores value.
                int userAge = Convert.ToInt32(Console.ReadLine());
                // If user input is less than 0, then moves on to exception.
                if (userAge <= 0)
                {
                    throw new ArgumentException();
                }

                // This sets a variable that fetches current date.
                DateTime now = DateTime.Now;
                // This sets variable for current year.
                int thisYear = now.Year;
                // This sets variable for current year minus user age.
                int whenBorn = thisYear - userAge;
                // Prints friendly message with result.
                Console.WriteLine("You were born approximately in the year: " + whenBorn + " !");
                Console.ReadLine();
            }
            // Exception message is active if user input is less than 0.
            catch (ArgumentException)
            {
                // Friendly message to user when user input is less than 0.
                Console.WriteLine("Please enter an age greater than 0. Try again.");
            }
            // Exception message is active if user input is not an integer.
            catch (Exception)
            {
                // Prints message to user.
                Console.WriteLine("Error: Invalid entry!");
            }
            Console.ReadLine();
        }
    }
}
