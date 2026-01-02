// C# Program: Operators Example

using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 5;

        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("a + b = " + (a + b));  // Addition
        Console.WriteLine("a - b = " + (a - b));  // Subtraction
        Console.WriteLine("a * b = " + (a * b));  // Multiplication
        Console.WriteLine("a / b = " + (a / b));  // Division
        Console.WriteLine("a % b = " + (a % b));  // Modulus

        // Comparison Operators
        Console.WriteLine("\nComparison Operators:");
        Console.WriteLine("a == b: " + (a == b)); // Equal to
        Console.WriteLine("a != b: " + (a != b)); // Not equal to
        Console.WriteLine("a > b: " + (a > b));   // Greater than
        Console.WriteLine("a < b: " + (a < b));   // Less than
        Console.WriteLine("a >= b: " + (a >= b)); // Greater than or equal
        Console.WriteLine("a <= b: " + (a <= b)); // Less than or equal

        // Logical Operators
        bool x = true;
        bool y = false;
        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine("x && y: " + (x && y)); // AND
        Console.WriteLine("x || y: " + (x || y)); // OR
        Console.WriteLine("!x: " + (!x));         // NOT
    }
}

/ * output
Arithmetic Operators:
a + b = 15
a - b = 5
a * b = 50
a / b = 2
a % b = 0

Comparison Operators:
a == b: False
a != b: True
a > b: True
a < b: False
a >= b: True
a <= b: False

Logical Operators:
x && y: False
x || y: True
!x: False
*/