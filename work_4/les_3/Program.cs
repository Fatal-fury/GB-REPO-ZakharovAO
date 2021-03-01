using System;

namespace les_3
{
    class Program
    {
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            int NumMonth;
            do
            {
                Console.Write("Введите порядковый номер месяца (1 - 12): ");
                NumMonth = Convert.ToInt32(Console.ReadLine());
                if (NumMonth >= 1 && NumMonth <= 12)
                {
                    Console.Write($"Время года: {GetSeasonsRU(GetSeasons(NumMonth))}");
                }
                else
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                }
            }
            while (NumMonth <= 1 || NumMonth >= 12);
        }
        static Seasons GetSeasons(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return (Seasons)1;
                case 3:
                case 4:
                case 5:
                    return (Seasons)2;
                case 6:
                case 7:
                case 8:
                    return (Seasons)3;
                default:
                    return (Seasons)4;
            }
        }
        static string GetSeasonsRU(Seasons s)
        {
            switch (s)
            {
                case Seasons.Winter:
                    return "Зима";
                case Seasons.Spring:
                    return "Весна";
                case Seasons.Summer:
                    return "Лето";
                default:
                    return "Осень";
            }
        }
    }
}
