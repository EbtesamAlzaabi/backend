using System;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start the application, call The function...
            Calculator();
        }

        static void Calculator()
        {
            try
            {
                Console.WriteLine("Hello In Calculator App...");
                Console.WriteLine("--------------------------------------------------");

                // Input First Number
                Console.Write("Welcome, please Enter First Number: ");
                int fnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("--------------------------------------------------");

                // Input Second Number
                Console.Write("Please Enter Second Number: ");
                int snum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("--------------------------------------------------");

                // Input Operation
                Console.Write("Please Enter An Operation (+, -, *, /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("--------------------------------------------------");

                // Logical operations 
                if (operation == '-')
                {
                    Console.WriteLine($"{fnum} {operation} {snum} = {fnum - snum}");
                }
                else if (operation == '+')
                {
                    Console.WriteLine($"{fnum} {operation} {snum} = {fnum + snum}");
                }
                else if (operation == '*')
                {
                    Console.WriteLine($"{fnum} {operation} {snum} = {fnum * snum}");
                }
                else if (operation == '/')
                {
                    // Validation for division by zero
                    if (snum != 0)
                    {
                        Console.WriteLine($"{fnum} {operation} {snum} = {fnum / snum}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation! Please use +, -, *, or /.");
                }
            }
            catch (Exception)
            {
                // Validation: Handles letters or invalid input
                Console.WriteLine("Input Error: Please enter valid numbers only.");
            }

            // Call the function

            Calculator();
        }
    }
}