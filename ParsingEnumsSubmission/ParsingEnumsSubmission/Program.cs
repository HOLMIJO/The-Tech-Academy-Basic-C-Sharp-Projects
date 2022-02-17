using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmission
{
    class Program
    {
        // Enum data type
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        // Set variable daysOfWeek from enum
        static public DaysOfWeek daysOfWeek;
		public static void Main(string[] args)
		{
			// Message to user to enter current day
            Console.WriteLine("Please enter the current day of the week and press ENTER.");
            // True False determined. Default is false.
            bool userInput = false;
            // While userInput is false, do what's below.
            while (!userInput)
            {
                // Try these in order
                try
                {
                    // User input stored and converted to lower case
                    string input = Console.ReadLine().ToLower();
                    // Variable converts back to upper case
                    input = input.First().ToString().ToUpper() + input.Substring(1);
                    // Try this first. This parses the days of the week an outputs the day if found in list.
                    if (Enum.TryParse<DaysOfWeek>(input, out daysOfWeek))
                    {
                        // Writes message with chosen day of the week
                        Console.WriteLine("You chose: " + daysOfWeek);
                        // If day was found in list, userInput becomes true.
                        userInput = true;
                    }
                    // If user input not found in list then print message.
                    else
                    {
                        // Prints message to user.
                        Console.WriteLine("Error: " + input + " not found. Please enter an actual day of the week.");
                    }
                }
                // If Exception errors, then print the message.
                catch (Exception ex)
                {
                    // After message prints, program breaks and terminates.
                    Console.WriteLine("Error: " + ex.Message);
                    break;
                }
                Console.ReadLine();
            }
		}
	}
}
