// C# Access Modifiers Example Program

using System;

namespace AccessModifierDemo
{
    // Base class
    class Person
    {
        public string Name = "Chandrakant";          // Public
        private int Salary = 50000;                  // Private
        protected int Age = 22;                      // Protected
        internal string City = "Pune";               // Internal
        protected internal string Country = "India"; // Protected Internal
        private protected string Email = "abc@gmail.com"; // Private Protected

        public void ShowPrivate()
        {
            Console.WriteLine("Private Salary: " + Salary);
        }
    }

    // Derived class
    class Student : Person
    {
        public void ShowDetails()
        {
            Console.WriteLine("Name: " + Name);        // Accessible
            Console.WriteLine("Age: " + Age);          // Accessible (protected)
            Console.WriteLine("City: " + City);        // Accessible (internal)
            Console.WriteLine("Country: " + Country);  // Accessible
            Console.WriteLine("Email: " + Email);      // Accessible
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Name: " + p.Name);
            Console.WriteLine("City: " + p.City);
            Console.WriteLine("Country: " + p.Country);
            p.ShowPrivate();

            Student s = new Student();
            s.ShowDetails();

            Console.ReadLine();
        }
    }
}

/* output
Name: Chandrakant
City: Pune
Country: India
Private Salary: 50000
Name: Chandrakant
Age: 22
City: Pune
Country: India
Email: abc@gmail.com
*/
