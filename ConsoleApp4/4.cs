using System;
namespace ConsoleApp4
{
    internal class Program4
    {
        static void Main4(string[] args)
        {
            Console.Write("Введите шестизначное число: ");
            string number = Console.ReadLine();

            if (number.Length != 6)
            {
                Console.WriteLine("Ошибка! Нужно ввести шестизначное число.");
                return;
            }

            Console.Write("Введите первый разряд (1-6): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второй разряд (1-6): ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < 1 || a > 6 || b < 1 || b > 6)
            {
                Console.WriteLine("Неправильный разряд!");
                return;
            }

            char[] digits = number.ToCharArray();

            char temp = digits[a - 1];
            digits[a - 1] = digits[b - 1];
            digits[b - 1] = temp;

            Console.WriteLine("Результат: " + new string(digits));
        }
    }
}
