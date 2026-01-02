
// Inheritance Example
using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Derived class
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Eat();  // Inherited from Animal
        dog.Bark();
    }
}


// output
//Animal is eating
// Dog is barking

