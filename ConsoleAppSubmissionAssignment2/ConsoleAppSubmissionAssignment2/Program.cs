using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // User is greeted and asked to pick a number between 1-10
            Console.WriteLine("I'm thinking of a secret number! Can you find it?\nPick a number between 1 and 10.");
            Console.ReadLine();
            // User input which is converted to an integer and the value is stored.
            int numberPicked = Convert.ToInt32(Console.ReadLine());
            // The variable for the Secret Number is being compared as True equals number 8.
            bool SecretNumber = numberPicked == 8;
            // During the course of the user making choices, the user will be met with various messages based on their number choice.

            do  // The Do statement fires off as long as the boolean SecretNumber value is False.
            {
                // This is saying if the case number is input, run these commands or statements
                switch (numberPicked)
                {
                    // Only the answers meeting these choices will get these messages.
                    case 7: // Only if the user chooses the number 7 will they get this message.
                        Console.WriteLine("You guessed 7. You're getting warmer. Try again.");
                        Console.WriteLine("Guess another number?");
                        numberPicked = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10: // Only if the user chooses the number 10 will they get this message.
                        Console.WriteLine("You guessed 10. So close! Try again.");
                        Console.WriteLine("Guess another number?");
                        numberPicked = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8: // Only if the user chooses the number 8 will they get this message.
                        Console.WriteLine("You guessed the number 8. That is correct!\nYou guessed the Secret Number!");
                        SecretNumber = true;
                        break;
                    default: // This is the default answer given for most wrong answers including choices above number 10 and beyond.
                        Console.WriteLine("You're not very good at this. Try again!");
                        Console.WriteLine("Guess another number?");
                        numberPicked = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            // This is saying While the SecretNumber is False, run the Do Statement
            while (!SecretNumber);

            Console.Read();
        }
    }
}
