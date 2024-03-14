using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть перше число:");
        if (!double.TryParse(Console.ReadLine(), out double number1))
        {
            Console.WriteLine("Неправильний формат числа. Будь ласка, введіть число.");
            return;
        }

        Console.WriteLine("Введіть друге число:");
        if (!double.TryParse(Console.ReadLine(), out double number2))
        {
            Console.WriteLine("Неправильний формат числа. Будь ласка, введіть число.");
            return;
        }

        double sum = number1 + number2;
        Console.WriteLine($"Сума чисел {number1} і {number2} дорівнює: {sum}");

    }
}
