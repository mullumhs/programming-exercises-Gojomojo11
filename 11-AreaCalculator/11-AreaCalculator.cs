﻿using System;

/*
===============================================================================
PROJECT 11: AREA CALCULATOR
===============================================================================
Objective:
- Enhance understanding of selection, user input, and maths operations by calculating areas of different shapes based on user choices.

Main Tasks:
1. Create a menu that asks the user to choose between calculating the area of a rectangle or triangle.
2. Prompt the user for their choice and store it in a variable.
3. Using selection, complete the program to calculate the area of either rectangles or triangles
4. Handle invalid menu choices with a warning message.
5. Create a "Press any key to exit..." message at the end of the program.

Questions:
1. What is the difference between Console.Write() and Console.WriteLine()?
2. How is the area of each shape calculated? What mathematical operations are used?

Extension Tasks:
1. Extend the program to calculate the area of other shapes and add them to the menu. E.g. Circle, trapezium.

Example:
- Below is an example of the program's output:

    Choose an Option:
    1. Area of Circle
    2. Area of Rectangle
    3. Area of Triangle

    2

    Enter Width: 3
    Enter Height: 4

    The area of the rectangle is 12

    "Press any key to exit...

Additional Resources:
- Mathematical Functions in C#: https://www.ictdemy.com/csharp/basics/mathematical-functions-in-csharp-net-math-library
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_11_AreaCalculator
    {
        static void Main(string[] args)
        {
            // Your code goes below here

            Console.WriteLine("Pick an option");
            Console.WriteLine("1. Area of a cicle");
            Console.WriteLine("2. Area of a triangle");
            Console.WriteLine("3. Area of a rectangle");

            string choice = Console.ReadLine();
            {
                if (choice == "1")
                {
                    Console.WriteLine("Enter radius: ");
                    double area = Convert.ToDouble(Console.ReadLine());
                    area = Math.PI * Math.Pow(area, 2);
                    Console.WriteLine($"The area of the circle is {area} ");
                    Console.ReadLine();

                }
            }
            if (choice == "2")
            {

                { 
                    Console.WriteLine("Enter width: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    double meow = height * width * 1/2;
                    Console.WriteLine($"The area of the triangle is {meow} ");
                    Console.ReadLine();
                }


                
            }
            if (choice == "3")
            {
                Console.WriteLine("Put in the base length matey: ");
                double baselenght = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter height: ");
                double height = Convert.ToDouble(Console.ReadLine());
                double rectangle = height * baselenght;
                Console.WriteLine($"The area of a rectangle is {rectangle}!");
                Console.ReadLine();
            }



        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================

meow

===============================================================================
*/