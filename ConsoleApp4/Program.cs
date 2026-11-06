using System;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 100: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 100)
                Console.WriteLine("Ошибка!");
            else if (n % 3 == 0 && n % 5 == 0)
                Console.WriteLine("Fizz Buzz");
            else if (n % 3 == 0)
                Console.WriteLine("Fizz");
            else if (n % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(n);
        }
    }
}
