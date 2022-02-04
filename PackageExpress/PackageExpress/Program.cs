using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the beginning of the program. Here the user is met with a greeting and prompt.
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.\nPress Enter to continue.");
            Console.ReadLine();
            // User is prompted for package weight and the variable is saved.
            Console.WriteLine("What is the package weight?");
            string pkgWeight = Console.ReadLine(); //User input is currently a string.
            float floatWeight = float.Parse(pkgWeight); // The Parse method converts a String to a Float, 
            // which works to hold a weight if it's not a whole number.

            // Here the users input of weight is qualified. If the weight exceeds 50, the user is given
            // an error message letting them know that the weight exceeds the limit and can't be shipped.
            // If the weight does not exceed the limit, the user is given a new instruction and may continue..  
            string weightResult = floatWeight > 50 ? "ERROR MESSAGE: Package too heavy to be shipped via Package Express. Have a good day" : "Please enter the package width?";
            Console.WriteLine(weightResult); // This holds the value of weight to be used later in the program.

            // This holds the width value of the package, to be used later in the program.
            string pkgWidth = Console.ReadLine();
            // Float is used again here in the event it's not a whole number.
            float floatWidth = float.Parse(pkgWidth);

            // The user is given a prompt to enter a value for package height.
            Console.WriteLine("Please enter package height?");
            // The value is taken as a string and stored for later in the program.
            string pkgHeight = Console.ReadLine();
            // Float is used here in the event it's not a whole number
            float floatHeight = float.Parse(pkgHeight);

            // The user is prompted to enter a value for package length.
            Console.WriteLine("Please enter package length?");
            // The given value is taken in as a string and saved for later in the program.
            string pkgLength = Console.ReadLine();
            // Float is used here in the event it's not a whole number.
            float floatLength = float.Parse(pkgLength);

            // Here we are making a variable which equals the total of width, height, length.
            float dimensionsTotal = floatWidth + floatHeight + floatLength;
            // If the dimensions of the package exceed 50, in width, height or length
            // the user will be given a message that the package is too big to be shipped.
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("ERROR MESSAGE: Package is too big to be shipped via Package Express. Have a good day!");
            }
            // If the dimensions are under 50, the program continues.
            else
            {
                // Here we are about to generate a final quote. The quote is comprised of multiplying
                // width, height, length then multiply weight and divide by 100.
                float pkgQuote = (floatWidth * floatHeight * floatLength) * floatWeight / 100;
                // This rounds (to two decimal points) the package quote amount.
                float finalQuote = (float)Math.Round(pkgQuote, 2);

                // Printing the final quote amount to console. 
                Console.WriteLine("The quoted cost to ship your package is: $" + finalQuote + " Have a good day!");
            }
            Console.ReadLine();
        }
    }
}
