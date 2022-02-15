using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class MathClass
    {
        // This is a void method that outputs an integer
        public void Divided(int input, out int sum)
        {
            // The sum varaible holds the division math operation
            sum = input / 2;
        }

        // This method will output an integer based on the number of items in the list
        public void Output(List<int> newList, out int total)
        {
            // Variable of total count of list items.
            total = newList.Count;
            // This iterates through the list, incrementing by 1.
            for (int i = 0; i < newList.Count; i++)
            {
                // This writes the list to the display.
                Console.WriteLine(newList[i]);
            }
        }

        // This is part of an overload method.
        public int Overload(int input2)
        {
            // Integer variable a.
            int a = 250;
            // Integer variable sumB takes user input.
            int sumB = a + input2;
            // This returns sumB to main program.
            return sumB;
        }

        // This is part of an overload method.
        public int Overload(int input2, int input3)
        {
            // Integer variable b.
            int b = 20;
            // Integer variable c.
            int c = 15;
            // Integer variable d.
            int d = 32;
            // Integer variable sumC.
            int sumC = b + c + d + input2 + input3;
            // This returns sumC to main program.
            return sumC;
        }

    }
}
