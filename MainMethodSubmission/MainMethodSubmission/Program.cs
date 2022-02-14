using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates a new object from the MathClass.
            MathClass inputA = new MathClass();
            // User is asked for an input of integer.
            Console.WriteLine("Please enter a whole number for some addition fun!");
            // This line stores the user input.
            int a = Convert.ToInt32(Console.ReadLine());
            // This calls the AddMeUp method.
            int result1 = inputA.AddMeUp(a);
            // This returns the sum and friendly message
            Console.WriteLine("Your chosen number plus 250, equals: {0}.", result1);
            Console.ReadLine();
            // User is asked for an input of integer.
            Console.WriteLine("Now let's enter a decimal that you would like to subtract 12.50 from.");
            // This line stores the user input.
            decimal b = Convert.ToDecimal(Console.ReadLine());
            // This calls the AddMeUp method.
            int result2 = inputA.AddMeUp(b);
            // This returns the sum and friendly message
            Console.WriteLine("Your chosen number minus 12.50 equals: {0}.", result2);
            Console.ReadLine();
            // User is asked for an input of integer which can take in a string.
            Console.WriteLine("Please type in another whole number.");
            // This line stores the user input.
            string c = Console.ReadLine();
            // This calls the AddMeUp method.
            int result3 = inputA.AddMeUp(c);
            // This returns the sum and friendly message
            Console.WriteLine("Your chosen number times 24 equals: {0}.", result3);
            Console.ReadLine();
        }
    }
}
