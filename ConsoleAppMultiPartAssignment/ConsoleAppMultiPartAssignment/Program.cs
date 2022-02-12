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
            //// Array of string variable format, instantiated.
            //string[] greetings = new string[] { "Welcome, ", "How are you today, ", "Have a great day, " };
            //// Message giving user instructions will be displayed.
            //Console.WriteLine("Enter your first name ,then press ENTER\nYou will receive a personalized message.");
            //// This line saves the input result
            //string userInput = Console.ReadLine();
            //// This statement iterates through the greetings, increments by one.
            //for (int i = 0; i < greetings.Length; i++)
            //{
            //    // Greetings + userInput displays
            //    Console.WriteLine(greetings[i] += userInput);
            //}
            //Console.ReadLine();

            ////// This is an infinite loop.
            ////for ( ; ; )
            ////{
            ////    Console.Write("x");
            ////}
            ////Console.ReadLine();

            //// Here c will print it's value
            //// as it increments by 1 
            //// until it meets the limit of 5
            //for (int c = 0; c < 5; c++)
            //{
            //    Console.WriteLine("Value of c: {0}", c);
            //}
            //Console.ReadLine();

            //// Here b will print it's value
            //// as it increments by 1 
            //// until it is less than or equal to 5
            //for (int b = 0; b <= 5; b++)
            //{
            //    Console.WriteLine("b value: {0}", b);
            //}
            //Console.ReadLine();

            //// A string of unique values
            //List<string> stateList = new List<string>() { "Arkansas", "Oregon", "Washington" };
            //// Instructions print for user.
            //Console.WriteLine("Enter the name of a state.");
            //// This line holds the value for index.
            //string userInput = Console.ReadLine();
            //// This says if the input is false then do foreach loop.
            //bool inputCheck = false;
            //int inputIndex;
            //foreach (string state in stateList)
            //{
            //    // If user input equals state in list, then print index.
            //    if (userInput == state)
            //    {
            //        inputCheck = true;
            //        inputIndex = stateList.IndexOf(state);
            //        Console.WriteLine(inputIndex);
            //    }
            //}
            //// If user input does not equal state in list, then print message.
            //if (inputCheck == false)
            //{
            //    Console.WriteLine("Index not found.");
            //}

            //Console.ReadLine();


            //// A string of unique values, with identicals included.
            //List<string> fruitList = new List<string>() { "Apple", "Orange", "Banana", "Apple", "Strawberry", "Orange", "Kiwi" };
            //// Instructions print for user.
            //Console.WriteLine("Enter the name of a fruit.");
            //// This line holds the value for index.
            //string fruitInput = Console.ReadLine();
            //// This iterates through list and if match in list, index will print
            //for (int index = 0; index < fruitList.Count; index++)
            //    if (fruitList[index] == fruitInput)
            //    {
            //        // This prints the associated index number
            //        Console.WriteLine(index);
            //    }
            //// If the user inputs something not in the list...
            //if (!fruitList.Contains(fruitInput))
            //{
            //    // This message will display to the user.
            //    Console.WriteLine("Sorry, item not found.");
            //}
            //Console.ReadLine();


            // A string of values, with some identicals included.
            List<string> sameList = new List<string>() { "Ace", "Bear", "Brandon", "Becca", "Joe", "Ace", "Stephen", "John", "Becca" };
            List<string> mtList = new List<string>();
            // Access the loop in order
            bool found = false;
            foreach (string same in sameList)
            {
                if (sameList.Contains("Becca") == true)
                {
                    found = true;
                    Console.WriteLine("This string Contains() HAS been repeated.");
                }
                if (mtList.Contains("Becca") == false)
                {
                    found = false;
                    Console.WriteLine("This string has NOT been repeated!");
                }
            }
            Console.ReadLine();
        }
    }
}
