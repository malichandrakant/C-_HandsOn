// C# Program: For Loop Example

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Numbers from 1 to 5 using for loop:");

        // For loop
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // Another example: sum of numbers
        int sum = 0;
        for (int j = 1; j <= 10; j++)
        {
            sum += j;
        }
        Console.WriteLine("\nSum of numbers from 1 to 10 = " + sum);

        // Example: print even numbers
        Console.WriteLine("\nEven numbers from 1 to 10:");
        for (int k = 1; k <= 10; k++)
        {
            if (k % 2 == 0)
                Console.WriteLine(k);
        }
    }
}


/ * output
Numbers from 1 to 5 using for loop:
1
2
3
4
5

Sum of numbers from 1 to 10 = 55

Even numbers from 1 to 10:
2
4
6
8
10
*/