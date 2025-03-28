using System;

public class Calculator
{
    // Сложение
    public int Add(int a, int b) => a + b;
    // Вычитание
    public int Subtract(int a, int b) => a - b;
    // Умножение
    public int Multiply(int a, int b) => a * b;
    // Деление
    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return (double)a / b;
    }
    // Возведение в степень
    public double Power(double a, double b)
    {
        if (a == 0 && b < 0)
        {
            throw new ArgumentException("Cannot raise zero to a negative power.");
        }
        return Math.Pow(a, b);
    }
}
