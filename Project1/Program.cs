/// Homework No. 7		Project 1
/// File Name: Program.cs
/// @author: Stephanie Zacharias 
/// Date:  October 26, 2020
///
/// Problem Statement: Define a Odometer class that will track fuel usage and
/// miles per gallon. Test all of the methods and constructors.
/// 
/// 
/// Overall Plan:
/// 1) Create new Odometer objects using each constructor.
/// 2) Test each method by manipulating each Odometer object.
/// 3) Print to the console after each manipulation to ensure that that the
///    method is behaving as expected.
///

using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer trip1 = new Odometer(); // default constructor
            trip1.Add(50, 10);
            Console.WriteLine("Fuel used for trip 1 is: " + trip1.mpg());
            Console.WriteLine(trip1.toString());

            Odometer trip2 = new Odometer(50, 10); // fully loaded constructor
            trip2.Add(100, 20);
            Console.WriteLine("Fuel used for trip2 is: " + trip2.mpg());
            Console.WriteLine(trip2.toString());

            if (trip1.equals(trip2))
            {
                Console.WriteLine("The two objects are the same");
            } else
            {
                Console.WriteLine("The two objects are not the same");
            }

            // TODO: test remaining methods

            trip1.reset();
            trip1.setMiles(50);
            trip1.setFuelUsed(4);
            Console.WriteLine("The mpg for trip 1 is: " + trip1.mpg());
            Console.WriteLine("The miles for trip 1 is: " + trip1.getMiles());
            Console.WriteLine("The fuel used for trip 1 is: " + trip1.getFuelUsed());




        }
        
    }
}
