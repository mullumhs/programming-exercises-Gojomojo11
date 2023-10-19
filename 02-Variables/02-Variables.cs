using System;

/*
===============================================================================
PROJECT 02: VARIABLES
===============================================================================
Objective:
- Understand and practice declaring variables and manipulating string data.

Main Tasks:
1. Create a string variable and assign it a value.
2. Output a message that contains this variable.
3. Make the program wait for input.

Questions:
1. What is a variable?Something that can be changed
2. What is a string? a data type used in programming, that is used to represent text rather than numbers

Extension Tasks:
1. Try creating two string variables and using them in the same message.
2. Use Google to work out how to change a variable to uppercase or lowercase before outputting it.

Additional Resources:
- Variables: https://www.tutorialspoint.com/csharp/csharp_variables.htm
- Data Types: https://www.tutorialspoint.com/csharp/csharp_data_types.htm
- String Manipulation: https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_02_Variables
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            string name = "Saturo Gojo";
            Console.WriteLine("Hey " + name);
            Console.ReadLine();
            string place = "to beat matthew up because you are way better than him";
            Console.WriteLine("go " + place + "!");
            Console.ReadLine();
            Console.WriteLine("You are so much better than matthew chubby clayton");
            Console.ReadLine();
            Console.WriteLine("you are himothy Saturo Matthew is so bad geez huh Mathew more like Badthew");
            Console.ReadLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/
