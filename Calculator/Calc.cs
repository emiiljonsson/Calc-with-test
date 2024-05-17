using System;

public class Calc
{
    // Metod för addition av två tal
    public double Addition(double num1, double num2)
    {
        return num1 + num2;
    }

    // Överlagrad metod för addition av en array
    public double Addition(double[] numbers)
    {
        double sum = 0;
        foreach (double number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    // Metod för subtraktion av två tal
    public double Subtraction(double num1, double num2)
    {
        return num1 - num2;
    }

    // Överlagrad metod för subtraktion av en array
    public double Subtraction(double[] numbers)
    {
        double result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result -= numbers[i];
        }
        return result;
    }

    // Metod för multiplikation av två tal
    public double Multiplication(double num1, double num2)
    {
        return num1 * num2;
    }

    // Metod för division av två tal
    public double Division(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Error: Number can not be divided by 0 (zero)");
        }
        return num1 / num2;
    }
}
