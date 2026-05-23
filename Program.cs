using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Simple Math Addition =====");
        Console.WriteLine();

        while (true)
        {
            double num1 = ReadNumber("Enter first number: ");
            double num2 = ReadNumber("Enter second number: ");

            double result = num1 + num2;

            Console.WriteLine($"\nResult: {num1} + {num2} = {result}");
            Console.WriteLine();

            Console.Write("Do you want to perform another addition? (yes/no): ");
            string answer = (Console.ReadLine() ?? "").Trim().ToLower();

            if (answer != "yes" && answer != "y")
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }

            Console.WriteLine();
        }
    }

    static double ReadNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? "";

            if (double.TryParse(input, out double number))
                return number;

            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
