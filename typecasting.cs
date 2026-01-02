//  Typecasting Example
using System;

class Program
{
    static void Main()
    {
        // Implicit Typecasting (smaller to larger type)
        int num1 = 100;
        double num2 = num1; // int to double (implicit)
        Console.WriteLine("Implicit Casting: int to double = " + num2);

        // Explicit Typecasting (larger to smaller type)
        double num3 = 9.78;
        int num4 = (int)num3; // double to int (explicit)
        Console.WriteLine("Explicit Casting: double to int = " + num4);

        // Typecasting from char to int
        char grade = 'A';
        int ascii = (int)grade;
        Console.WriteLine("Char to Int (ASCII) = " + ascii);
    }
}


/ * output 
Implicit Casting: int to double = 100
Explicit Casting: double to int = 9
Char to Int (ASCII) = 65
*/

