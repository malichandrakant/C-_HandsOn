// C# Program: Methods Example

using System;

class Program
{
    // Method without parameters and without return value
    static void Greet()
    {
        Console.WriteLine("Hello! Welcome to C# programming.");
    }

    // Method with parameters and without return value
    static void PrintSum(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum of " + a + " and " + b + " = " + sum);
    }

    // Method with parameters and return value
    static int Multiply(int x, int y)
    {
        return x * y;
    }

    static void Main()
    {
        // Call method without parameters
        Greet();

        // Call method with parameters
        PrintSum(10, 20);

        // Call method with return value
        int result = Multiply(5, 6);
        Console.WriteLine("Multiplication result = " + result);
    }
}
// output
/*
Hello! Welcome to C# programming.
Sum of 10 and 20 = 30
Multiplication result = 30
*/