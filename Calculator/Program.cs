using System;

class Program
{
    static void Main(string[] args)
    {
        Calc calculator = new Calc();
        Console.WriteLine("Welcome to the calculator!");

        while (true)
        {
            Console.WriteLine("Please choose an option below");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            Console.WriteLine("0. Exit");

            Console.Write("Write your option: ");
            int option = GetValidOption();

            if (option == 0)
            {
                Console.WriteLine("Thanks for using this calculator, Bye!");
                break;
            }

            double[] numbers = GetValidNumbers(option);

            try
            {
                double result = 0;
                switch (option)
                {
                    case 1:
                        result = calculator.Addition(numbers);
                        break;

                    case 2:
                        result = calculator.Subtraction(numbers);
                        break;

                    case 3:
                        result = calculator.Multiplication(numbers[0], numbers[1]);
                        break;

                    case 4:
                        result = calculator.Division(numbers[0], numbers[1]);
                        break;

                    default:
                        Console.WriteLine("Error: Unavailable choice. Try again!");
                        continue;
                }

                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static int GetValidOption()
    {
        while (true)
        {
            try
            {
                int option = int.Parse(Console.ReadLine());
                if (option >= 0 && option <= 4)
                {
                    return option;
                }
                else
                {
                    Console.WriteLine("Error: Invalid option. Please enter a number between 0 and 4.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
        }
    }

    static double[] GetValidNumbers(int option)
    {
        if (option == 1 || option == 2)
        {
            Console.Write("Enter the numbers separated by spaces: ");
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] parts = input.Split(' ');
                    double[] numbers = Array.ConvertAll(parts, double.Parse);
                    return numbers;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter valid numbers separated by spaces.");
                }
            }
        }
        else
        {
            double[] numbers = new double[2];
            numbers[0] = GetValidNumber("first");
            numbers[1] = GetValidNumber("second");
            return numbers;
        }
    }

    static double GetValidNumber(string order)
    {
        while (true)
        {
            Console.Write($"Write the {order} number: ");
            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
        }
    }
}
