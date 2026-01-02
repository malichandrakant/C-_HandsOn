// Classes and Objects

using System;

class Person
{
    // Fields
    public string Name;
    public int Age;

    // Method
    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
    }
}

class Program
{
    static void Main()
    {
        // Create object
        Person person1 = new Person();
        person1.Name = "Chandrakant";
        person1.Age = 25;

        // Call method
        person1.Greet();
    }
}
/*
output
Hello, my name is Chandrakant and I am 25 years old.
*/
