using System;

namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Message for user to input number and to press enter.
            Console.WriteLine("Greetings! What number would you like to do your math operations on?\nEnter a number to continue, and press ENTER.");
            // This line stores user input and holds for math operations.
            int number = Convert.ToInt32(Console.ReadLine());
            // Message to user...
            Console.WriteLine("I will now add 25 to your number.");
            // This creates a new object of the Counting class and names it "Object".
            Counting Object = new Counting();
            // This variable return1 accesses the Counting class methods...
            int return1 = Object.AddIt(number);
            // This line prints the sum of the math operation.
            Console.WriteLine(return1);
            // Message to user...
            Console.WriteLine("I will now subtract 2 from your number.");
            // This variable return2 accesses the Counting class methods...
            int return2 = Object.SubIt(number);
            // This line prints the sum of the math operation.
            Console.WriteLine(return2);
            // Message to user...
            Console.WriteLine("I will now multiply your number by 10.");
            // This variable return3 accesses the Counting class methods...
            int return3 = Object.TimesIt(number);
            // This line prints the sum of the math operation.
            Console.WriteLine(return3);
            // Closing message to
            Console.ReadLine();
        }
    }
}

