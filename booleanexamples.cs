// C# Program: Booleans Example

using System;

class Program
{
    static void Main()
    {
        // Boolean variables
        bool isStudent = true;
        bool hasLaptop = false;

        Console.WriteLine("Is Student: " + isStudent);
        Console.WriteLine("Has Laptop: " + hasLaptop);

        // Logical operations
        Console.WriteLine("\nLogical Operations:");
        Console.WriteLine("isStudent AND hasLaptop: " + (isStudent && hasLaptop)); // AND
        Console.WriteLine("isStudent OR hasLaptop: " + (isStudent || hasLaptop));  // OR
        Console.WriteLine("NOT isStudent: " + (!isStudent));                        // NOT

        // Boolean comparison
        int age = 20;
        int requiredAge = 18;
        bool canVote = age >= requiredAge; // comparison returns boolean
        Console.WriteLine("\nCan Vote: " + canVote);
    }
}

/* output 
Is Student: True
Has Laptop: False

Logical Operations:
isStudent AND hasLaptop: False
isStudent OR hasLaptop: True
NOT isStudent: False

Can Vote: True
*/