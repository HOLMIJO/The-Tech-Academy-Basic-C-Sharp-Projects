using System;

namespace ConditionalStatementChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World! Please enter your name.");
            string name = Console.ReadLine();
            

            if (name == "Joseph")
            {
                Console.WriteLine("Hello, " + name + " welcome to the Conditional Statement Challenge!");
                Console.ReadLine();
            }
            else if (name == "Brandon")
            {
                Console.WriteLine("Hello, " + name + " welcome to the Conditional Statement Challenge!");
                Console.ReadLine();
            }
            else if (name == "Becca")
            {
                Console.WriteLine("Hello, " + name + " welcome to the Conditional Statement Challenge!");
                Console.ReadLine();
            }
            else if (name == "Stephen")
            {
                Console.WriteLine("Hello, " + name + " welcome to the Conditional Statement Challenge!");
                Console.ReadLine();
            }
            else if (name == "Bill")
            {
                Console.WriteLine("Hello, " + name + " welcome to the Conditional Statement Challenge!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry, Your name is neither Joseph, Brandon, Becca, Stephen, or Bill!");
                Console.ReadLine();
            }
        }
    }
}
