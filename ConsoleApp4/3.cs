using System;
namespace ConsoleApp4
{
    internal class Program3
    {
        static void Main3(string[] args)
        {
            Console.Write("Введите четыре цифры: ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int number = a * 1000 + b * 100 + c * 10 + d;

            Console.WriteLine("Полученное число: " + number);
        }
    }
}
