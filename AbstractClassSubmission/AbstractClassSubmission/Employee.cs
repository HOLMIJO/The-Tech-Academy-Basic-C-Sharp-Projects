using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public class Employee : Person, IQuittable
    {
        // SayName method is implemented here, inherited properties from Person class.
        public override void SayName()
        {
            // Friendly message taking from the Person class through inheritance.
            Console.WriteLine("Greetings: {0} {1}!", firstName, lastName);
        }


        // Uses same method as IQuittable interface
        public void Quit(Employee employee)
        {
            // Friendly greeting giving user instructions.
            Console.WriteLine("Please advise your employment status.\nAre you a current employee? \nPlease enter y or n and press ENTER.");
            // This stores the user input
            string response = Console.ReadLine();
            // If user answers y, they are given friendly greeting.
            if (response == "y")
            {
                // Friendly response for user input of Y.
                Console.WriteLine("Great, we are glad you are employed here!");
            }
            // If user answers n, they are given the following response.
            if (response == "n")
            {
                // Friendly response based on user input of n.
                Console.WriteLine("We are sorry to see you go. We wish you well in all of your future endeavors.");
            }
            // If user answers other than y or n, they are given the following response.
            else
            {
                // Friendly response based on user input other than y.
                Console.WriteLine("You have entered an invalid response.");
            }
            Console.ReadLine();
        }
    }
}
