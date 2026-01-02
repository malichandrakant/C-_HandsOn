// C# Program: Math Class Example

using System;

class Program
{
    static void Main()
    {
        double num1 = 9.0;
        double num2 = 2.0;
        double num3 = -4.5;

        // Square root
        Console.WriteLine("Square root of " + num1 + " = " + Math.Sqrt(num1));

        // Power
        Console.WriteLine(num1 + " raised to " + num2 + " = " + Math.Pow(num1, num2));

        // Absolute value
        Console.WriteLine("Absolute value of " + num3 + " = " + Math.Abs(num3));

        // Round
        double num4 = 4.7;
        Console.WriteLine(num4 + " rounded = " + Math.Round(num4));

        // Ceiling
        Console.WriteLine(num4 + " ceiling = " + Math.Ceiling(num4));

        // Floor
        Console.WriteLine(num4 + " floor = " + Math.Floor(num4));

        // Maximum and Minimum
        Console.WriteLine("Maximum of " + num1 + " and " + num2 + " = " + Math.Max(num1, num2));
        Console.WriteLine("Minimum of " + num1 + " and " + num2 + " = " + Math.Min(num1, num2));

        // Random number between 0 and 1
        Random rand = new Random();
        Console.WriteLine("Random number between 0 and 1 = " + rand.NextDouble());
    }
}

/ * Output 
Square root of 9 = 3
9 raised to 2 = 81
Absolute value of -4.5 = 4.5
4.7 rounded = 5
4.7 ceiling = 5
4.7 floor = 4
Maximum of 9 and 2 = 9
Minimum of 9 and 2 = 2
Random number between 0 and 1 = 0.374829
*/