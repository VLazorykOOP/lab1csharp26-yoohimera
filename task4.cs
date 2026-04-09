using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть стать (м - чоловік, ж - жінка):");
        string gender = Console.ReadLine()?.ToLower(); 

        if (gender == "м")
        {
            Console.WriteLine("Можливі чоловічі імена: Олександр, Максим, Андрій, Дмитро, Артем.");
        }
        else if (gender == "ж")
        {
            Console.WriteLine("Можливі жіночі імена: Марія, Олена, Анастасія, Вікторія, Анна.");
        }
        else
        {
            Console.WriteLine("Помилка: введено некоректну стать. Використовуйте 'м' або 'ж'.");
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}
