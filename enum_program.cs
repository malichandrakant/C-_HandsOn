// C# Enum Example Program

using System;

namespace EnumExample
{
    // Enum declaration
    enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Day today = Day.Friday;

            Console.WriteLine("Today is: " + today);
            Console.WriteLine("Enum Value: " + (int)today);

            Console.ReadLine();
        }
    }
}

// Output
Today is: Friday
Enum Value: 4
