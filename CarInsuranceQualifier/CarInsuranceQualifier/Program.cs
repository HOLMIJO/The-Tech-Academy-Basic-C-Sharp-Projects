using System;

namespace CarInsuranceQualifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Car Insurance Qualifier Program begins...
            Console.WriteLine("Welcome To The Car Insurance Qualifier!");
            Console.WriteLine("Press Enter to begin...");
            Console.ReadLine();
            Console.WriteLine("What is your age?");
            int AgeOfUser = Convert.ToInt32(Console.ReadLine()); // This line takes the users age and saves result

            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine("If you have, please respond with \"True\", otherwise respond with \"False\".");
            Console.WriteLine("Please respond with \"True\" or \"False\":");
            bool DUIs = bool.Parse(Console.ReadLine()); // This line takes boolean result and saves result

            Console.WriteLine("How many speeding tickets do you have?");
            int Tickets = Convert.ToInt32(Console.ReadLine()); //This line saves the input result

            Console.WriteLine("Do you qualify?\nIf you DO qualify, the result will display as TRUE.\nIf you do NOT qualify, the result will display as FALSE.");
            Console.WriteLine(AgeOfUser > 15 && Tickets < 3 && DUIs == false); //*** See Comments Below! ***
            // The above line determines qualification of user based on age must be older than 15,
            // and determines if user has/had less than 3 tickets and NO DUIs.
            Console.ReadLine();

        }
    }
}
