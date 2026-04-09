using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть внутрішній радіус (r1): ");
        double r1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть зовнішній радіус (r2): ");
        double r2 = Convert.ToDouble(Console.ReadLine());

        if (r2 > r1)
        {
            // Формула: Area = π * (r2² - r1²)
            double area = Math.PI * (Math.Pow(r2, 2) - Math.Pow(r1, 2));
            
            Console.WriteLine($"\nПлоща кільця: {area:F2}");
        }
        else
        {
            Console.WriteLine("\nПомилка: Зовнішній радіус має бути більшим за внутрішній!");
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу, щоб вийти...");
        Console.ReadKey();
    }
}
