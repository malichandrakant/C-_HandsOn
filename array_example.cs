// C# Program: Arrays Example

using System;

class Program
{
    static void Main()
    {
        // Declare and initialize an array of integers
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Array elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element at index " + i + " = " + numbers[i]);
        }

        // Modify an element
        numbers[2] = 35;
        Console.WriteLine("\nAfter modifying index 2:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element at index " + i + " = " + numbers[i]);
        }

        // Array length
        Console.WriteLine("\nLength of array: " + numbers.Length);

        // Using foreach loop
        Console.WriteLine("\nArray elements using foreach loop:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Find sum of array elements
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine("\nSum of array elements = " + sum);
    }
}

/* Output

Array elements:
Element at index 0 = 10
Element at index 1 = 20
Element at index 2 = 30
Element at index 3 = 40
Element at index 4 = 50

After modifying index 2:
Element at index 0 = 10
Element at index 1 = 20
Element at index 2 = 35
Element at index 3 = 40
Element at index 4 = 50

Length of array: 5

Array elements using foreach loop:
10
20
35
40
50

Sum of array elements = 155
*/