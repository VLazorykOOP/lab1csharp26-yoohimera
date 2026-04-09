using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double radiusSquared = x * x + y * y;

        if (Math.Abs(radiusSquared - 144) < 0.0001 && y <= x && x >= 0 || 
            Math.Abs(y - x) < 0.0001 && radiusSquared <= 144 && x >= 0 ||
            Math.Abs(x) < 0.0001 && radiusSquared <= 144 && y <= 0)
        {
            Console.WriteLine("На межі");
        }
       
        else if (radiusSquared < 144 && y < x && x > 0)
        {
            Console.WriteLine("Так");
        }
    
        else
        {
            Console.WriteLine("Ні");
        }

        Console.ReadKey();
    }
}
