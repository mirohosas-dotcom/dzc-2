using System;
namespace ConsoleApp4
{
    internal class Program5
    {
        static void Main5(string[] args)
        {
            Console.Write("Введите дату (дд.мм.гггг): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            string season = "";

            if (date.Month == 12 || date.Month == 1 || date.Month == 2)
                season = "Winter";
            else if (date.Month >= 3 && date.Month <= 5)
                season = "Spring";
            else if (date.Month >= 6 && date.Month <= 8)
                season = "Summer";
            else
                season = "Autumn";

            Console.WriteLine(season + " " + date.DayOfWeek);
        }
    }
}
