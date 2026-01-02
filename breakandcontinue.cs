// C# Program: Break and Continue Example

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Example of break in for loop:");
        // Break example: stop loop when i == 5
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Breaking the loop at i = " + i);
                break; // exit the loop
            }
            Console.WriteLine(i);
        }

        Console.WriteLine("\nExample of continue in for loop:");
        // Continue example: skip number 5
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Skipping i = " + i);
                continue; // skip current iteration
            }
            Console.WriteLine(i);
        }
    }
}

/* Output

Example of break in for loop:
1
2
3
4
Breaking the loop at i = 5

Example of continue in for loop:
1
2
3
4
Skipping i = 5
6
7
8
9
10
*/