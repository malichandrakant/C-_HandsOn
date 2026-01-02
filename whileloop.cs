// C# Program: While Loop Example

using System;

class Program
{
    static void Main()
    {
        int count = 1;

        Console.WriteLine("Numbers from 1 to 5 using while loop:");

        // While loop
        while (count <= 5)
        {
            Console.WriteLine(count);
            count++; // increment to avoid infinite loop
        }

        // Another example: sum of numbers
        int sum = 0;
        int i = 1;
        while (i <= 10)
        {
            sum += i; // add i to sum
            i++;
        }
        Console.WriteLine("\nSum of numbers from 1 to 10 = " + sum);
    }
}
/* Output

Numbers from 1 to 5 using while loop:
1
2
3
4
5

Sum of numbers from 1 to 10 = 55
*/