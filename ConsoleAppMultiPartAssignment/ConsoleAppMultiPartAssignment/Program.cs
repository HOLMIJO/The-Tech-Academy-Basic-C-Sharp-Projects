using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiPartAssignment
{
    class Program
    {
        // private static int i;

        static void Main(string[] args)
        {
            // Array of string variable format, instantiated.
            string[] greetings = new string[] { "Welcome, ", "How are you today, ", "Have a great day, " };
            // Message giving user instructions will be displayed.
            Console.WriteLine("Enter your first name ,then press ENTER\nYou will receive a personalized message.");
            // This line saves the input result
            string userInput = Console.ReadLine();
            // This statement iterates through the greetings, increments by one.
            for (int i = 0; i < greetings.Length; i++)
            {
                // Greetings + userInput displays
                Console.WriteLine(greetings[i] += userInput);
            }
            Console.ReadLine();

            //// This is an infinite loop.
            //for ( ; ; )
            //{
            //    Console.Write("x");
            //}
            //Console.ReadLine();

            // Here c will print it's value
            // as it increments by 1 
            // until it meets the limit of 5
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Value of c: {0}", c);
            }
            Console.ReadLine();

            // Here b will print it's value
            // as it increments by 1 
            // until it is less than or equal to 5
            for (int b = 0; b <= 5; b++)
            {
                Console.WriteLine("b value: {0}", b);
            }
            Console.ReadLine();

            // A string of unique values
            List<string> profileList = new List<string>();
            profileList.Add("Name: Joseph Holmin");
            profileList.Add("Phone Number: +1(901) 677-4221");
            profileList.Add("Email: holminj@icloud.com");
            profileList.Add("State: Arkansas");
            profileList.Add("Country: USA");
            // User is given instructions and prompted to enter specific search terms.
            Console.WriteLine("Please enter an index number to choose an item.\n\"0\" for the Name, \"1\" for the Phone Number, \n\"2\" for the Email, \"3\" for the State, \nand \"4\" for the Country.");
            int userIndex = Convert.ToInt32(Console.ReadLine()); // This line saves the input result
            if (userIndex > 4) // If user inputs an index greater than 5 they get message.
            {
                Console.WriteLine("ERROR MESSAGE: The chosen index is out of range.  Have a good day!");
            }
            else // If user inputs index in range, the information will display
            {
                // Prints a message plus info from chosen index by user.
                Console.WriteLine("You chose: " + profileList[userIndex]);
            }
            Console.ReadLine();



        }
    }
}
