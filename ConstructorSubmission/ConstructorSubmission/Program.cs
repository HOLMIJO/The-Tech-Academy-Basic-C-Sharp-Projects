using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class Program
    {
        static void Main()
        {
            // create a consant variable.
            const string owner = "Stephen Patterson";
            Console.WriteLine(owner);
            // create a variable using the keyword "var"
            var ourPups = new Dictionary<string, int>() { ["Taco"] = 1, ["Sweetie"] = 15, ["Skeeter"] = 9, ["Red"] = 12 };
            // This prints a specific item, being the int of age from key in the dictionary.
            Console.WriteLine(ourPups["Sweetie"]);
            ConstructorSubmissionAssignment.K9 k9 = new ConstructorSubmissionAssignment.K9("Ace", 14);
            Console.WriteLine(k9.Name + " " + k9.Age);
            Console.ReadLine();
            
        }
    }
}