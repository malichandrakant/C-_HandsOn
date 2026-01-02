
// User Input Example

using System;

class Program
{
    static void Main()
    {
        // Ask user for their name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine(); // Read string input

        // Ask user for their age
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine()); // Read integer input

        // Ask user for their height
        Console.Write("Enter your height (in feet): ");
        double height = Convert.ToDouble(Console.ReadLine()); // Read double input

        // Display user input
        Console.WriteLine("\n--- User Details ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
    }
}


/* Enter your name: Chandrakant
Enter your age: 25
Enter your height (in feet): 5.9

--- User Details ---
Name: Chandrakant
Age: 25
Height: 5.9
*/