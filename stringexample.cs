// C# Program: Strings Example

using System;

class Program
{
    static void Main()
    {
        // Declare string variables
        string firstName = "Chandrakant";
        string lastName = "Mali";

        // Concatenation
        string fullName = firstName + " " + lastName;
        Console.WriteLine("Full Name: " + fullName);

        // Length of string
        Console.WriteLine("Length of first name: " + firstName.Length);

        // Convert to uppercase and lowercase
        Console.WriteLine("Uppercase: " + fullName.ToUpper());
        Console.WriteLine("Lowercase: " + fullName.ToLower());

        // Substring
        Console.WriteLine("Substring of first name (0-5): " + firstName.Substring(0, 5));

        // Replace
        string newName = fullName.Replace("Mali", "Kumar");
        Console.WriteLine("After Replace: " + newName);

        // Check if contains a word
        Console.WriteLine("Contains 'Chandra'? " + fullName.Contains("Chandra"));

        // Trim spaces
        string text = "   Hello World!   ";
        Console.WriteLine("Trimmed Text: '" + text.Trim() + "'");

        // Split string
        string[] words = fullName.Split(' ');
        Console.WriteLine("First Name from Split: " + words[0]);
        Console.WriteLine("Last Name from Split: " + words[1]);
    }
}
/ *
Full Name: Chandrakant Mali
Length of first name: 10
Uppercase: CHANDRAKANT MALI
Lowercase: chandrakant mali
Substring of first name (0-5): Chand
After Replace: Chandrakant Kumar
Contains 'Chandra'? True
Trimmed Text: 'Hello World!'
First Name from Split: Chandrakant
Last Name from Split: Mali
*/