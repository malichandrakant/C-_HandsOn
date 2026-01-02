// Encapsulation Example

using System;

class Person
{
    private string name; // private field

    // Property to access private field
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Chandrakant"; // Set value
        Console.WriteLine("Person Name: " + p.Name); // Get value
    }
}
