// C# Program: If-Else Example
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Check voting eligibility using if-else
        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }

        // Multiple conditions using if-else-if
        if (age < 13)
        {
            Console.WriteLine("You are a child.");
        }
        else if (age >= 13 && age < 20)
        {
            Console.WriteLine("You are a teenager.");
        }
        else if (age >= 20 && age < 60)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a senior citizen.");
        }
    }
}
// output
Enter your age: 25
You are eligible to vote.
You are an adult.
