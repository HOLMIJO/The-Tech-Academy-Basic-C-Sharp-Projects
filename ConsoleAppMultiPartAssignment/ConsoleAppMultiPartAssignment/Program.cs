using System;
using System.Collections.Generic;

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

            // This is an infinite loop.
            for ( ; ; )
            {
                Console.Write("x");
            }
            Console.ReadLine();

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
            Console.WriteLine("Please enter a search term.\nYou may choose \"Name\", \"Phone Number\", \"Email\", \"State\", or \"Country\".\nPlease enter your selection now.");
            string strList = Convert.ToString(Console.ReadLine()); //This line saves the input result

            switch (profileList)
            {
                case "Name":
                    Console.WriteLine("The answer is: " + profileList[strList]);
                    break;

                case "Phone Number":
                    Console.WriteLine("The answer is: " + profileList[strList]);
                    break;

                case "Email":
                    Console.WriteLine("The answer is: " + profileList[strList]);
                    break;

                case "State":
                    Console.WriteLine("The answer is: " + profileList[strList]);
                    break;

                case "Country":
                    Console.WriteLine("The answer is: " + profileList[strList]);
                    break;

                default:
                    Console.WriteLine("Index is not available.");
                    break;
            }
            Console.ReadLine();


        }
    }
}
