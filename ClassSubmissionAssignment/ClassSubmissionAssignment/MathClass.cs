using System;
using System.Collections.Generic;
using System.Text;

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
            // Variable of total count of list items
            total = newList.Count;
            // This iterates through the list, incrementing by 1.
            for (int i = 0; i < newList.Count; i++)
            {
                // This writes the list to the display
                Console.WriteLine(newList[i]);
            }
            
        }


    }
}
