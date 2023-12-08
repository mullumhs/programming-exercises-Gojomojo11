using System;

/*
===============================================================================
PROJECT 17: TEMPERATURE CONVERSION
===============================================================================
Objective:
- Utilise functions to create a program that converts temperatures between Celsius and Fahrenheit based on user input.

Example Output:
- This is how your program should behave:

    What would you like to do?
    1. Celsius to Fahrenheit
    2. Fahrenheit to Celsius
    1
    Enter temperature in Celsius: 0
    That is 32 Fahrenheit

Pseudocode:
    BEGIN Main
        choice = MainMenu()
        IF choice = 1 THEN
            result = CelsiusToFahrenheit()
            PRINT result
        ELSE IF choice = 2 THEN
            result = FahrenheitToCelsius()
            PRINT result
        ELSE
            PRINT "Invalid Choice!"
        END IF
    END Main

    BEGIN CelsiusToFahrenheit
        c = GetTemperature("Celsius")
        f = (c * 9/5) + 32
        RETURN f
    END CelsiusToFahrenheit 

    BEGIN FahrenheitToCelsius
        f = GetTemperature("Fahrenheit")
        c = (f - 32) * 5/9
        RETURN c
    END FahrenheitToCelsius

    BEGIN GetTemperature(unit)
        PRINT "Enter temperature in " + unit
        INPUT temp
        RETURN temp
    END GetTemperature

Main Tasks:
1. Write a function to convert Celsius to Fahrenheit.
2. Write a function to convert Fahrenheit to Celsius.
3. Implement a menu for the user to choose which conversion they want to perform.
4. Display the result of the conversion based on the user's choice.

Questions:
1. What did you find challenging about implementing an entire program yourself?

Extension Tasks:
1. Add an option in the menu for the user to exit the program.
2. Enhance the program to handle invalid input gracefully without crashing.
3. Research and implement a function to convert temperature to and from Kelvin.
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_17_TemperatureConversion
    {
        private static string choice;

        static void Main(string[] args)
        {
            // Write your code here
            Console.WriteLine("What would you like to do 1. Celcius to Farenheit or 2. Farenheit to Celcius");
              string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                double celcius = ConvertCelciusToFarenheit();
                Console.WriteLine($"That is {celcius} celcius");

            }
            else if (choice == "2")
            {
                double f = ConvertFarenheitToCelcius();
                Console.WriteLine($"That is {f} Farenheit");
            }
            else
            {
                Console.WriteLine("invalid choice!");
            }
            // Wait for key press before exiting
            Console.ReadLine();
        }

        private static double ConvertCelciusToFarenheit()
        {
            double f = GetTemp("F");
            double celcius = f - 32 * 1.8;
            return celcius;
        }

        private static double GetTemp(string v)
        {
            Console.Write($"Enter Temp (in {v}) to convert: ");
            double distance = int.Parse(Console.ReadLine());
            return distance;
        }

        private static double ConvertFarenheitToCelcius()
        {
            double c = GetTemp("C");
            double f = c / 1.6;
            return f;
        }

    }

   
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/
