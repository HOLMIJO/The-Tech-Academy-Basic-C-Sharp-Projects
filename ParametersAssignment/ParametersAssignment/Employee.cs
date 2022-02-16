using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // This is the Employee class with a generic parameter type
    public class Employee<T>
    {
        // This is a list with a generic type parameter
        public List<T> things;
    }
}
