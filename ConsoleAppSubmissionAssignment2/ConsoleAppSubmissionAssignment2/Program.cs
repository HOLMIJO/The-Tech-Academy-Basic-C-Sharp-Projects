using System;

namespace ConsoleAppSubmissionAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // User is greeted with overview and asked to press Enter to continue.
            Console.WriteLine("Hello World, Let's get those numbers rolling\nCounting from 1 to 25.\nPress ENTER to start!");
            Console.ReadLine();
            // We're going to count from 1 ongoing. While the numbers are less than 25, they will incrementally count up.
            // Once the increment reaches 25, the counting stops.
            int index = 1;
            while (index <= 25)
            {
                Console.WriteLine(index); // The result of index is 1
                index++; // index = 1 then increments by 1 onward.
            }
            // Message displays once the incremental count reaches 25.
            Console.WriteLine("That was fun, let's do it all again!\nPress ENTER to continue.");
            Console.ReadLine();
            // We start the counting over. Index is set to 1.
            index = 26;
            // Do count from 1 onwards incrementing by 1.
            do
            {
                // Write the index of 1, incrementing by 1, as long as the indexed incremented is 25 or less.
                Console.WriteLine(index);
                index++;
            } while (index <= 50);
            // The closing message is displayed.
            Console.WriteLine("Now the fun is done!");
            Console.ReadLine();
        }
    }
}
