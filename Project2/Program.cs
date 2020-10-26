/// Homework No. 7		Project 2
/// File Name: Program.cs
/// @author: Stephanie Zacharias
/// Date:  October 26, 2020
///
/// Problem Statement: Define a Temperature class that compares and converts
/// temperatures between Fahrenheit and Celcius.
/// 
/// 
/// Overall Plan:
/// 1) Create a new Temperature objects using each constructor.
/// 2) Test each getter method on each Temperature object.
/// 3) Test each setter method on the Temperature objects.
/// 4) Test the equals method.
///

using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Temperature objects
            Temperature temp1 = new Temperature();
            Temperature temp2 = new Temperature(89.1, 'F');

            // Test each getter method on each Temperature object
            Console.WriteLine("Temp 1 in Fahrenheit is: " + temp1.getFahrenheit());
            Console.WriteLine("Temp 2 in Fahrenheit is: " + temp2.getFahrenheit());
            Console.WriteLine("Temp 1 in Celcius is: " + temp1.getCelcius());
            Console.WriteLine("Temp 2 in Celcius is: " + temp2.getCelcius());

            // Test the setter and toString methods
            temp1.setTemperature(78.56);
            temp1.setScale('F');
            Console.WriteLine(temp1.toString());

            temp2.setTemperatureAndScale(40.59, 'C');
            Console.WriteLine(temp2.toString());


            // Test the Equals method
            if (temp1.Equals(temp2))
            {
                Console.WriteLine("The two temperatures are the same.");
            } else
            {
                Console.WriteLine("The two temperatures are not the same.");
            }

            temp1.setTemperatureAndScale(40.59, 'C');

            if (temp1.Equals(temp2))
            {
                Console.WriteLine("The two temperatures are the same.");
            }
            else
            {
                Console.WriteLine("The two temperatures are not the same.");
            }
        }
    }
}
