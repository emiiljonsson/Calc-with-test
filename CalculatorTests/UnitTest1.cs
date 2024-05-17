using System;
using Xunit;

public class CalcTests
{
    private readonly Calc calculator = new Calc();

    [Fact]
    public void Addition_TwoNumbers_ReturnsSum()
    {
        double result = calculator.Addition(3.5, 2.5);
        Assert.Equal(6.0, result);
    }

    [Fact]
    public void Addition_ArrayNumbers_ReturnsSum()
    {
        double[] numbers = { 1.1, -3.3, 5, 7, 8.8 };
        double result = calculator.Addition(numbers);
        Assert.Equal(18.6, result);
    }

    [Fact]
    public void Subtraction_TwoNumbers_ReturnsDifference()
    {
        double result = calculator.Subtraction(10.0, 5.5);
        Assert.Equal(4.5, result);
    }

    [Fact]
    public void Subtraction_ArrayNumbers_ReturnsDifference()
    {
        double[] numbers = { 20, 5, 3 };
        double result = calculator.Subtraction(numbers);
        Assert.Equal(12.0, result);
    }

    [Fact]
    public void Multiplication_TwoNumbers_ReturnsProduct()
    {
        double result = calculator.Multiplication(4.0, 2.5);
        Assert.Equal(10.0, result);
    }

    [Fact]
    public void Division_TwoNumbers_ReturnsQuotient()
    {
        double result = calculator.Division(10.0, 2.0);
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Division_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Division(10.0, 0));
    }
}
