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
        public void Quit()
        {
            // Friendly greeting giving user instructions.
            Console.WriteLine("The employee has quit.");
        }
         
        // Employee Id properties
        public int Id { get; set; }


        // Overloading of Boolean method checking for equality of 2 employees.
        public static bool operator== (Employee employee, Employee employee1)
        {
            // This will return true or false based on equality of employee Id. 
            return employee.Id == employee1.Id;
        }

        // Overloading of Boolean method checking for inequality, being NOT equal values of 2 employees.
        public static bool operator!= (Employee employee, Employee employee1)
        {
            // This will return true or false based on inequality, being NOT equal to employee Id. 
            return employee.Id != employee1.Id;
        }
    }
}
