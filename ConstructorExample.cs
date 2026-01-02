// Constructor Example

using System;

class Person
{
    public string Name;
    public int Age;

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
    }
}

class Program
{
    static void Main()
    {
        // Object with constructor
        Person person1 = new Person("Chandrakant", 25);
        person1.Greet();
    }
}
