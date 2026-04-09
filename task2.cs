using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть тризначне число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int d1 = number / 100;        
        int d2 = (number / 10) % 10;  
        int d3 = number % 10;        

        // Перевіряємо, чи всі вони рівні
        if (d1 == d2 && d2 == d3)
        {
            Console.WriteLine("Так, всі цифри однакові.");
        }
        else
        {
            Console.WriteLine("Ні, цифри різні.");
        }

        Console.ReadKey();
    }
}
