// C# Exception Handling Example

using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                int result = 10 / num;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input");
            }
            finally
            {
                Console.WriteLine("Program execution completed");
            }

            Console.ReadLine();
        }
    }
}

// output

/* input

0

output

Enter a number: 0
Error: Cannot divide by zero
Program execution completed
*/

