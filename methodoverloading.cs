// C# Program: Method Overloading Example

using System;

class Program
{
    // Method 1: Adds two integers
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method 2: Adds three integers
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Method 3: Adds two doubles
    static double Add(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        int sum1 = Add(10, 20);           // Calls first method
        int sum2 = Add(5, 15, 25);        // Calls second method
        double sum3 = Add(4.5, 3.2);      // Calls third method

        Console.WriteLine("Sum of 10 and 20 = " + sum1);
        Console.WriteLine("Sum of 5, 15, 25 = " + sum2);
        Console.WriteLine("Sum of 4.5 and 3.2 = " + sum3);
    }
}

/* output

Sum of 10 and 20 = 30
Sum of 5, 15, 25 = 45
Sum of 4.5 and 3.2 = 7.7
*/