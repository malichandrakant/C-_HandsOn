// Polymorphism (Method Overriding)

using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();

        myAnimal.Sound(); // Animal makes a sound
        myDog.Sound();    // Dog barks
    }
}
