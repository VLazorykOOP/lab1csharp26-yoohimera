using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть перше число (ділене):");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге число (дільник):");
        double b = Convert.ToDouble(Console.ReadLine());

     
        double result = SquareOfDivision(a, b);
        
        if (!double.IsNaN(result))
        {
            Console.WriteLine($"\nКвадрат частки чисел {a} і {b} дорівнює: {result:F4}");
        }

        Console.ReadKey();
    }

    /// <summary>
    /// </summary>
    static double SquareOfDivision(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("Помилка: Ділення на нуль!");
            return double.NaN; 
        }

        double quotient = x / y;
        double squared = Math.Pow(quotient, 2); 
        
        return squared;
    }
}
