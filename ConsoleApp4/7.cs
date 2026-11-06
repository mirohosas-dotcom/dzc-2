using System;
namespace ConsoleApp4
{
    internal class Program7
    {
        static void Main7(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("Чётные числа:");

            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
