using System;
namespace ConsoleApp4
{
    internal class Program2
    {
        static void Main2(string[] args)
        {
            Console.Write("Введите число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = a * b / 100;

            Console.WriteLine("Результат: " + result);
        }
    }
}