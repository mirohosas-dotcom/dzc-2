using System;
namespace ConsoleApp4
{
    internal class Program6
    {
        static void Main6(string[] args)
        {
            Console.WriteLine("1 - Фаренгейт в Цельсий");
            Console.WriteLine("2 - Цельсий в Фаренгейт");

            Console.Write("Выберите действие: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите температуру: ");
            double t = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
                Console.WriteLine("Цельсий: " + ((t - 32) * 5 / 9));
            else if (choice == 2)
                Console.WriteLine("Фаренгейт: " + (t * 9 / 5 + 32));
            else
                Console.WriteLine("Ошибка выбора!");
        }
    }
}
