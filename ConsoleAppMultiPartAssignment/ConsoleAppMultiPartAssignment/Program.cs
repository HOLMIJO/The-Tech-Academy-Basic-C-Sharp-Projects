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

            //for (int a = 0; a < 25; a--)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();


            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Value of c: {0}", c);
            }
            Console.ReadLine();
            

            for (int b = 0; b <= 5; b++)
            {
                Console.WriteLine("b value: {0}", b);
            }
            Console.ReadLine();



        }
    }
}
