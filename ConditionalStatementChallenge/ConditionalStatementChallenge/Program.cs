using System;

namespace ConditionalStatementChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello World! Please enter your name.");
            Convert.ToString(Console.ReadLine());
            Console.ReadLine();
            

            if (name == "Joseph")
            {
                Console.WriteLine("Your name is Joseph!");
                Console.ReadLine();
            }
            else if (name == "Brandon")
            {
                Console.WriteLine("Your name is NOT Joseph!");
                Console.ReadLine();
            }
            else if (name == "Becca")
            {
                Console.WriteLine("Your name is NOT Joseph!");
                Console.ReadLine();
            }
            else if (name == "Stephen")
            {
                Console.WriteLine("Your name is NOT Joseph!");
                Console.ReadLine();
            }
            else if (name == "Bill")
            {
                Console.WriteLine("Your name is NOT Joseph!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your name is neither Brandon, Becca, Stephen, or Bill!");
                Console.ReadLine();
            }
        }
    }
}
