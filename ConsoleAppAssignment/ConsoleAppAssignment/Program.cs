using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This asks the user to enter a number
            // then multiplies it and prints result to console
            Console.WriteLine("Enter a number from 1 to 10,000,000 and press Enter.");
            uint firstNumber = (uint)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Let's multiply " + firstNumber + " by 50!");
            Console.WriteLine(firstNumber * 50);
            Console.ReadLine();

            // This asks the user to enter a number
            // then divides it by 12.5 and prints result to console
            Console.WriteLine("Enter another number from 1 to 10,000 and press Enter.");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Let's divide the " + secondNumber + " by 12.5!");
            Console.WriteLine(secondNumber / 12.5m);
            Console.ReadLine();

            // This asks the user to enter a number
            // then checks to see if number is greater than 50
            // and prints boolean result to console. Only true or false will appear.
            Console.WriteLine("Enter another whole number and press Enter.");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number was: " + thirdNumber);
            Console.ReadLine();
            Console.WriteLine("If the number you added is greater than 50\nThe result will show as \"True\",\nOtherwise it will display as \"False\".");
            int bigSmall = (int)thirdNumber;
            int basePick = 50;
            bool isNot = bigSmall >= basePick;
            Console.WriteLine(isNot);
            Console.ReadLine();

            // This asks the user to enter a number
            // then divides it by 7 and prints result to console
            Console.WriteLine("Enter a number from 1 to 100 and press Enter.");
            int fourthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If the number can be divided by 7, the result will display the remainder.\nIf the number is ODD, it will appear as \"1\".\nIf the number is EVEN, it will appear as \"0\".");
            Console.ReadLine();
            Console.WriteLine("Let's divide the " + fourthNumber + " by 7!");
            Console.ReadLine();
            Console.WriteLine("The result is: " + fourthNumber % 7);
            Console.ReadLine();
        }
    }
}
