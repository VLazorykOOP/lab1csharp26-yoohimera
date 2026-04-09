using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        double result = a + (a + b - 1) / (Math.Pow(a, 2) + 1) - a * b;

        Console.WriteLine($"Результат: {result}");
    }
}
