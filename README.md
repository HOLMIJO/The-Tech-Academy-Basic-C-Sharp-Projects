# The-Tech-Academy-Basic-C-Sharp-Projects

C# Projects for The Tech Academy

# Projects:
* ACME Accounting
* Anonymous Income Comparison Tool
* Car Insurance Qualifier Tool
* Package Express
* The Tech Academy Daily Report Demo
* Car Insurance (ASP.NET MVC)
* TwentyOne


This is a display of sample projects that I made using C# and .NET.

# Writing and Running Code in C# Assignment
The assignment was to build a welcome screen for new accounting software your company is developing.
When the program is run, Welcome to Acme Accounting Systems is printed in the console.
Below that, "Remember, we're "accounting" on you!" is printed to the console.

# The Tech Academy Daily Report Demo
A questionnaire asking students for their daily submission like a status report.
Inputs include their; name, the course they are on, page number and more.

# Console Application Assignment for doing math in C#
Takes an input from the user, multiplies it by 50, then prints the result to the console.
Takes an input from the user, adds 25 to it, then prints the result to the console.
Takes an input from the user, divides it by 12.5, then prints the result to the console.
Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
Takes an input from the user, divides it by 7, then prints the remainder to the console.

# Math and Comparison Operator Submission Assignment
Take the input of Person 1 for their Hourly Rate and hours worked.
Take the same information from Person Two.
Display the Annual Salary of Person 1 and Person 2.
Compare if Person 1 makes more than Person 2.

# Boolean Logic Submission Assignment
An application setting up a basic approval program for car insurance.
It will ask the applicant some questions and return a "true" or "false" at the end to determine whether or not the applicant qualified for car insurance.

# Package Express
A program to create a console-based application for getting a shipping quote for a package.
The first line of the program gives a welcome message.
The user is then prompted for an input of the weight of the package.
With an if statement if the input for the weight is greater then 50, an error message will display and the program will end.
If package is under 50 the user is prompted for inputs of height, length, and width.
If the total dimensions is greater than 50 an error message will display.
If under 50 the results will be calculated using weight * width * height * length / 100.
The result of that calculation is the quote displayed to the user as a dollar amount with an itemized list of the inputs.

# Do/While Statement Assignment
Created a console app that includes a Do/While Statement with a Switch statement for options.
Options are to choose a number of 1 - 5 with and a final default which will take you back to choosing from 1 - 5 with a while loop.
The Boolean variable starts as false. Until it is changed to true by choosing a number 1-5.
Each number 1 - 5 has its own unique statement that will be printed to the console.
If 6 or greater is chosen, the default will present the question again of choosing 1 - 5 until 1 - 5 is chosen.

# String Assignment
A string assignment demonstrating string Concatenation.
Using the .ToUpper method.
Using the StringBuilder Class to be able to make changes to a string.
In C# string values in themselves are not mutable and take up memory if not in a StringBuilder object.

# Console App Array Submission Assignment
Created a one-dimensional Array of strings with a question that would ask the user to input a int value of 1 through 4 to represent the value of the index for the array.
It would print the value for the index of the array.
Also created a one-dimensional array of integers.
Asking the user again to input a int value representing the value of the index which would then print the value of that index to the console.
Created a list of strings.
An input from the user representing the index of the list will print to the console the value of that index in the list.

# Console App Six Part Submission Assignment
* Part 1.
Set up a one-dimensional array of strings with a question for user input.
Created a loop that iterates through each string in the array and adds the user's text input to the end of each string.
Created a loop that prints off each string in the array on a separate line.

* Part 2.
Created an infinite loop demonstration.
Provided the proper coding to fix the infinite loop so that it will execute properly.

* Part 3.
Created a loop where the comparison that's used to determine whether to continue iterating the loop is a "<" operator.
Created a loop where the comparison that's used to determine whether to continue iterating the loop is a "<=" operator.

* Part 4.
Created a list of strings where each item in the list is unique.
Asked the user to input text to search for in the list.
Created a loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
Added code to the loop to check if the suer put in text that isn't on the list and, if they did, tells the user their input is not on the list.
Once a match has been found the loop will stop.

* Part 5.
Created a list of strings that has at least two identical strings in the list.
Asked the user to input text to search for in the list.
Created a loop that iterates through the list and then displays the indices of the items matching the user input.
Added code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.

* Part 6.
created a list of strings that has at least two identical strings in the list.
Created a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.

# Console App Strings and Integers Submission Assignment(try/catch)
Created a list of integers.
Asked the user for a input to divide each number in the list by.
Created a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
Tested for 0 division error and if the input was a string error.
Then set up a try/catch statement to catch these errors.
Looped back around with a while loop to ask again for an input that can be used in the division code.

# Calling Methods Submission Assignment
Created a class, in that class created three methods, each of which will take one integer parameter in and return an integer.
The methods do some math operations on the received parameter.
The class is in a separate .cs file in the application.
In the main() program, there is a WriteLine method statement asking the user for a number they want to do the math operations on.
Made calls from the Main() program for each method in turn, passing the user input to the methods.
Displaying all results from the methods to the consol.

# Main Method Submission Assignment
Created a class, in that class created method that will take in an integer.
Created a math operation for the integer then returned the answer as an integer.
Created two more methods of the same name utilizing method overflow with different values passed into each.
The second method is a decimal value and the third method a string.
The string value was converted to an integer for a multiplication calculation.
The result was return as an integer value.

# Method Submission Assignment
Created a class.
In that class, created a method that takes two integers are parameters.
One of the parameters were optional as an input being passed in as 0.
With requests in the console, asked the user to input two numbers one at a time.
The second input could be left black if the user didn't want to input a second number.
Made the call to the method in the class, passing in the one or two numbers entered.
If the second number was black, it was automatically supplied with a 0 as the value as stated from above.

# Method Class Submission Assignment
Created a class.
In that class, created a void method that takes two integers as parameters with the method performing a math calculation on the first integer and displaying the second integer to the screen.
In the main() method of the console app, instantiated the class.
Called the method in the class passing in tow numbers.
Called the method in the class specifying the parameters by name.

# Class Submission Assignment
Created a class and in that class, created a void method that outputs an integer.
The input to be divided is from an input provided by the user and will be divided by two.
The class is instantiated in the main program.
Also created a method with output parameters, an overload method.
Declared a class to be static.

# Methods And Objects Submission Assignment
Created a Class called Person and gave it two properties, each of data type string.
Gave this class a void method called SayName() that takes no parameters and simply prints to the console the full name of an employee.
Created another class called Employee and had it inherit from the Person class.
Gave the Employee class a property called Id and had it set to the data type int.
Within the Main method, instantiated and initialized an Employee class.
Called the superclass method SayName on the employee object.

# Abstract Class Submission Assignment
Created an abstract class called Person with two string properties.
Created a method named SayName().
Created a class called Employee to inherit from the person class.
Implemented the SayName method inside of the employee class.
In the Main() method, instantiated the Employee object with firstName sample and lastName Student.
Called the SayName() method on the object.

# Polymorphism Submission Assignment
Created an interface called IQuittable and had it define a void method called Quit().
The Employee class inherits that interface and implements the quit() method.
Using polymorphism to create an object of type IQuittable and call the quit() method on it.

# Operators Submission Assignment
Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id Property.

# Parsing Enums Submission Assignment
Created an enum for the days of the week.
Prompted the suer to enter the current day of the week.
Assign the value to the variable of the enum data type.
Wrapped the statement in a try/catch block, had the catch print to the console "Please enter an actual day of the week."

# Struct Assignment
Created a struct called Number and gave it the property Amount, the data type is decimal.
In the Main() method, created an object of data type Number and assign an amount to it.

# Lambda Submission Assignment
In the main() method, created a list of 10 employees, Each employee having a first and last name as well as an id number.
Two of the employees have the same first name(Joe).
Using a foreach loop, created a new list of all employees with the first name "Joe".
Performed the same action again with a lambda expression.
Using a lambda expression, made a list of all employees with an id number greater than 5.

# Input Assignment
Ask a user for an input.
Log the input to a text file using the System.IO file.writealltext method.
Display to the console the inputted information from the saved text file using the System.lO.file.ReadAllText method printing to the console using the system.console.WriteLine method.

# Date/Time Submission Assignment
created a DateTime.now method to print the current time and date that the program is ran.
Included an input for the user asking for a number.
Used the number to calculate how many hours from now what time and date it will be.

# Constructor Submission Assignment
Created a const variable.
Created a variable using the keyword "var".
Demonstrated chaining two constructors together.

# Try/Catch Assignment
Asked the user if they had a birthday this year yet and then for their age.
Displayed the year the user was born with a datetime calculation.
Used a try/catch for any exceptions.
Displayed appropriate error message if the user enters zero or negative numbers.
Also displayed a general message for all other exceptions.

# ASP.NET MVC Entity Framework Submission Assignment(Car Insurance)
https://github.com/HOLMIJO/CarInsurance
Created an ASP.NET MVC Entity Framework web page that is for an Auto Insurance company.
Starts with a base of 50 dollars a month quote.
There are if statements to check for age of the customer, make and model of the vehicle, year of the vehicle, speeding tickets, DUI and if Full Coverage is needed.
Calculations in if/else statements for each item.
Then saved after the calculation is done to a database that shows the customer information and the quote of the cost of insurance.

# Entity Framework Code-First app
Created a basic Entity Framework Code-First app that creates a basic Student database and adds one student.

# TwentyOne (BlackJack) Game
https://github.com/HOLMIJO/The-Tech-Academy-Projects/tree/main/TwentyOne
Game is a pretty good solo play game of TwentyOne with selected BlackJack rules.
Game was created using Visual Studio 2019.
