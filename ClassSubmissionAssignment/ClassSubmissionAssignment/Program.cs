using System;

namespace ClassSubmissionAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            // This instantiates the MathClass class.
            MathClass math1 = new MathClass();
            // Gives friendly message for user input.
            Console.WriteLine("Please enter a number, then press ENTER.");
            // This stores user input to a variable.
            int input = Convert.ToInt32(Console.ReadLine());
            // This variable holds the math operation
            int sum;
            // This calls on the input number and outputs the result
            math1.Divided(input, out sum);
            // This line prints a friendly message including the results.
            Console.WriteLine("Your number divided by 2 equals: " + sum);
            Console.ReadLine();
        }
    }
}
